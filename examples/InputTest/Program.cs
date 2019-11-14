﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace InputTest
{
    internal class Program
    {
        private static void Main()
        {
            var opts = WindowOptions.Default;
            opts.UseSingleThreadedWindow = false;
            opts.FramesPerSecond = 60;
            opts.UpdatesPerSecond = 60;
            var window = Window.Create(opts);
            window.Load += () =>
            {
                var input = window.GetInput();
                input.ConnectionChanged += DoConnect;
                Console.WriteLine("Now, go press buttons in the window and you'll see the feedback here.");
                foreach (var gamepad in input.Gamepads)
                {
                    if (!gamepad.IsConnected) continue;
                    DoConnect(gamepad, gamepad.IsConnected);
                }

                foreach (var joystick in input.Joysticks)
                {
                    if (!joystick.IsConnected) continue;
                    DoConnect(joystick, joystick.IsConnected);
                }

                foreach (var keyboard in input.Keyboards)
                {
                    if (!keyboard.IsConnected) continue;
                    DoConnect(keyboard, keyboard.IsConnected);
                }

                foreach (var mouse in input.Mice)
                {
                    if (!mouse.IsConnected) continue;
                    DoConnect(mouse, mouse.IsConnected);
                }
            };
            window.Run();
        }

        private static void GamepadOnTriggerMoved(IGamepad g, Trigger t)
        {
            Console.WriteLine($"G{g.Index}> {t.Index} trigger moved: {t.Position}");
        }

        private static void GamepadOnThumbstickMoved(IGamepad g, Thumbstick t)
        {
            Console.WriteLine($"G{g.Index}> {t.Index} thumbstick moved: ({t.X}, {t.Y})");
        }

        private static void JoystickOnHatMoved(IJoystick arg1, Hat arg2)
        {
            Console.WriteLine($"J{arg1.Index}> {arg2.Index} hat moved: {arg2.Position}");
        }

        private static void JoystickOnAxisMoved(IJoystick arg1, Axis arg2)
        {
            Console.WriteLine($"J{arg1.Index}> {arg2.Index} axis moved: {arg2.Position}");
        }

        private static void JoystickOnButtonUp(IJoystick arg1, Button arg2)
        {
            Console.WriteLine($"J{arg1.Index}> {arg2.Name} down.");
        }

        private static void JoystickOnButtonDown(IJoystick arg1, Button arg2)
        {
            Console.WriteLine($"J{arg1.Index}> {arg2.Name} down.");
        }

        private static void InputGamepadOnButtonDown(IGamepad arg1, Button arg2)
        {
            Console.WriteLine($"G{arg1.Index}> {arg2.Name} down. {(int) arg2.Name}");
        }

        private static void InputGamepadOnButtonUp(IGamepad arg1, Button arg2)
        {
            Console.WriteLine($"G{arg1.Index}> {arg2.Name} up.");
        }

        public static void DoConnect(IInputDevice device, bool isConnected)
        {
            Console.WriteLine(isConnected
                ? $"Device {device.Name} connected"
                : $"Device {device.Name} disconnected");
            if (device is IGamepad gamepad && device.IsConnected)
            {
                Console.WriteLine($"Discovered controller {gamepad.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    gamepad.ButtonDown += InputGamepadOnButtonDown;
                    gamepad.ButtonUp += InputGamepadOnButtonUp;
                    gamepad.ThumbstickMoved += GamepadOnThumbstickMoved;
                    gamepad.TriggerMoved += GamepadOnTriggerMoved;
                }
                else
                {
                    gamepad.ButtonDown -= InputGamepadOnButtonDown;
                    gamepad.ButtonUp -= InputGamepadOnButtonUp;
                    gamepad.ThumbstickMoved -= GamepadOnThumbstickMoved;
                    gamepad.TriggerMoved -= GamepadOnTriggerMoved;
                }

                Console.Write("    Buttons: ");
                const string s = "\n             ";
                Console.WriteLine(string.Join(s, gamepad.Buttons.Select(x => x.Name + (x.Pressed ? "(1)" : "(0)"))));
                Console.WriteLine($"    {gamepad.Thumbsticks.Count} thumbsticks found.");
                Console.WriteLine($"    {gamepad.Triggers.Count} triggers found.");
            }
            else if (device is IJoystick joystick)
            {
                Console.WriteLine($"Discovered joystick {joystick.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    joystick.ButtonDown += JoystickOnButtonDown;
                    joystick.ButtonUp += JoystickOnButtonUp;
                    joystick.AxisMoved += JoystickOnAxisMoved;
                    joystick.HatMoved += JoystickOnHatMoved;
                }
                else
                {
                    joystick.ButtonDown -= JoystickOnButtonDown;
                    joystick.ButtonUp -= JoystickOnButtonUp;
                    joystick.AxisMoved -= JoystickOnAxisMoved;
                    joystick.HatMoved -= JoystickOnHatMoved;
                }

                Console.Write("    Buttons: ");
                const string s = "\n             ";
                Console.WriteLine(string.Join(s, joystick.Buttons.Select(x => x.Name + (x.Pressed ? "(1)" : "(0)"))));
            }
            else if (device is IKeyboard keyboard)
            {
                Console.WriteLine($"Discovered keyboard {keyboard.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    keyboard.KeyDown += KeyboardOnKeyDown;
                    keyboard.KeyUp += KeyboardOnKeyUp;
                }
                else
                {
                    keyboard.KeyDown -= KeyboardOnKeyDown;
                    keyboard.KeyUp -= KeyboardOnKeyUp;
                }

                Console.Write("    Buttons: ");
                Console.WriteLine(string.Join(", ", keyboard.SupportedKeys.Select(x => x)));
            }
            else if (device is IMouse mouse)
            {
                Console.WriteLine($"Discovered mouse {mouse.Index} (Connected: {isConnected})");
                if (isConnected)
                {
                    mouse.MouseUp += MouseOnMouseUp;
                    mouse.MouseDown += MouseOnMouseDown;
                    mouse.Scroll += MouseOnScroll;
                    mouse.MouseMove += MouseOnMouseMove;
                }
                else
                {
                    mouse.MouseUp -= MouseOnMouseUp;
                    mouse.MouseDown -= MouseOnMouseDown;
                    mouse.Scroll -= MouseOnScroll;
                    mouse.MouseMove -= MouseOnMouseMove;
                }

                Console.Write("    Buttons: ");
                Console.WriteLine(string.Join(", ", mouse.SupportedButtons.Select(x => x)));
                Console.WriteLine($"    {mouse.ScrollWheels.Count} scroll wheels.");
            }
        }

        private static void MouseOnMouseMove(IMouse arg1, PointF arg2)
        {
            Console.WriteLine($"M{arg1.Index}> Moved: {arg2}");
        }

        private static void MouseOnScroll(IMouse arg1, ScrollWheel arg2)
        {
            Console.WriteLine($"K{arg1.Index}> Scrolled: ({arg2.X}, {arg2.Y})");
        }

        private static void MouseOnMouseDown(IMouse arg1, MouseButton arg2)
        {
            Console.WriteLine($"M{arg1.Index}> {arg2} down.");
        }

        private static void MouseOnMouseUp(IMouse arg1, MouseButton arg2)
        {
            Console.WriteLine($"M{arg1.Index}> {arg2} up.");
        }

        private static void KeyboardOnKeyUp(IKeyboard arg1, Key arg2, int _)
        {
            Console.WriteLine($"K{arg1.Index}> {arg2} up.");
        }

        private static void KeyboardOnKeyDown(IKeyboard arg1, Key arg2, int _)
        {
            Console.WriteLine($"K{arg1.Index}> {arg2} down.");
        }
    }
}