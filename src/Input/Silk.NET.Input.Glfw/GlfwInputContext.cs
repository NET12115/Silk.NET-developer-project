// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input.Internals;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwInputContext : IInputContext
    {
        private readonly GlfwGamepad[] _gamepads = new GlfwGamepad[16];
        private readonly GlfwJoystick[] _joysticks = new GlfwJoystick[16];
        private readonly GlfwKeyboard[] _keyboards = new GlfwKeyboard[1];
        private readonly GlfwMouse[] _mice = new GlfwMouse[1];
        private readonly IGlfwSubscriber[] _subscribers = new IGlfwSubscriber[2];
        private Action<double> _update;
        private IView _window;

        public unsafe GlfwInputContext(IView window)
        {
            void OnConnectionChanged(IInputDevice a, bool b) => ConnectionChanged?.Invoke(a, b);

            if (!(window is GlfwWindow))
            {
                throw new ArgumentNullException
                    (nameof(window), "Attempted to create input context for null or non-GLFW window.");
            }

            Handle = window.Handle;
            for (var i = 0; i < _gamepads.Length; i++)
            {
                _gamepads[i] = new GlfwGamepad(i) {OnConnectionChanged = OnConnectionChanged};
            }

            for (var i = 0; i < _joysticks.Length; i++)
            {
                _joysticks[i] = new GlfwJoystick(i) {OnConnectionChanged = OnConnectionChanged};
            }

            _subscribers[0] = _keyboards[0] = new GlfwKeyboard();
            _subscribers[1] = _mice[0] = new GlfwMouse();

            Gamepads = new IsConnectedWrapper<GlfwGamepad>(_gamepads);
            Joysticks = new IsConnectedWrapper<GlfwJoystick>(_joysticks);
            Keyboards = _keyboards;
            Mice = _mice;

            GlfwInputPlatform.RegisterWindow((WindowHandle*) Handle, _subscribers);
            window.Update += _update = _ =>
            {
                foreach (var updatable in _mice)
                {
                    updatable.Update();
                }

                foreach (var updatable in _gamepads)
                {
                    updatable.Update();
                }

                foreach (var updatable in _joysticks)
                {
                    updatable.Update();
                }
            };

            _window = window;
        }

        public unsafe void Dispose()
        {
            _window.Update -= _update;
            GlfwInputPlatform.UnregisterWindow((WindowHandle*) Handle, _subscribers);
            foreach (var gamepad in _gamepads)
            {
                gamepad.Dispose();
            }

            foreach (var joystick in _joysticks)
            {
                joystick.Dispose();
            }

            foreach (var mouse in _mice)
            {
                mouse.Dispose();
            }
        }

        public nint Handle { get; }
        public IReadOnlyList<IGamepad> Gamepads { get; }
        public IReadOnlyList<IJoystick> Joysticks { get; }
        public IReadOnlyList<IKeyboard> Keyboards { get; }
        public IReadOnlyList<IMouse> Mice { get; }
        public IReadOnlyList<IInputDevice> OtherDevices { get; } = new IInputDevice[0];
        public event Action<IInputDevice, bool>? ConnectionChanged;
    }
}
