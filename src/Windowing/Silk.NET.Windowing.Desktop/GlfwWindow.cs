// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    /// <summary>
    /// A Silk.NET window, using GLFW as a backend.
    /// </summary>
    public class GlfwWindow : IWindow
    {
        private Glfw glfw = Glfw.GetAPI();
        private unsafe WindowHandle* WindowPtr;

        private bool _isVisible;

        /// <inheritdoc />
        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                unsafe {
                    if (value) {
                        glfw.ShowWindow(WindowPtr);
                    }
                    else {
                        glfw.HideWindow(WindowPtr);
                    }
                }

                _isVisible = value;
            }
        }

        /// <inheritdoc />
        public IntPtr Handle
        {
            get
            {
                unsafe {
                    return new IntPtr(WindowPtr);
                }
            }
        }

        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; }

        private Point _position;

        /// <inheritdoc />
        public Point Position
        {
            get => _position;
            set
            {
                unsafe {
                    glfw.SetWindowPos(WindowPtr, value.X, value.Y);
                }

                _position = value;
            }
        }

        private Size _size;

        /// <inheritdoc />
        public Size Size
        {
            get => _size;
            set
            {
                unsafe {
                    glfw.SetWindowSize(WindowPtr, value.Width, value.Height);
                }

                _size = value;
            }
        }

        /// <inheritdoc />
        public double FramesPerSecond { get; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; }

        /// <inheritdoc />
        public GraphicsAPI API { get; }

        private string _title;

        /// <inheritdoc />
        public string Title
        {
            get => _title;
            set
            {
                unsafe {
                    glfw.SetWindowTitle(WindowPtr, value);
                }

                _title = value;
            }
        }

        private WindowState _windowState;

        /// <inheritdoc />
        public WindowState WindowState
        {
            get => _windowState;
            set
            {
                unsafe {
                    switch (value) {
                        case WindowState.Normal:
                            glfw.RestoreWindow(WindowPtr);
                            break;
                        case WindowState.Minimized:
                            glfw.IconifyWindow(WindowPtr);
                            break;
                        case WindowState.Maximized:
                            glfw.MaximizeWindow(WindowPtr);
                            break;
                        case WindowState.Fullscreen:
                            var monitor = glfw.GetWindowMonitor(WindowPtr);
                            var mode = glfw.GetVideoMode(monitor);
                            glfw.SetWindowMonitor(WindowPtr, monitor, 0, 0, mode->Width, mode->Height,
                                mode->RefreshRate);
                            break;
                    }
                }

                _windowState = value;
                OnWindowStateChanged(value);
            }
        }

        private WindowBorder _windowBorder;

        /// <inheritdoc />
        public WindowBorder WindowBorder
        {
            get => _windowBorder;
            set
            {
                unsafe {
                    switch (value) {
                        case WindowBorder.Hidden:
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, false);
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
                            break;

                        case WindowBorder.Resizable:
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, true);
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, true);
                            break;

                        case WindowBorder.Fixed:
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Decorated, true);
                            glfw.SetWindowAttrib(WindowPtr, WindowAttributeSetter.Resizable, false);
                            break;
                    }
                }

                _windowBorder = value;
            }
        }

        private VSyncMode _vSync;

        /// <inheritdoc />
        public VSyncMode VSync
        {
            get => _vSync;
            set
            {
                switch (value) {
                    case VSyncMode.Off:
                        glfw.SwapInterval(0);
                        break;

                    case VSyncMode.On:
                        glfw.SwapInterval(1);
                        break;

                    default:
                        throw new NotImplementedException();
                }

                _vSync = value;
            }
        }

        public GlfwWindow(WindowOptions options)
        {
            unsafe {
                // Title and Size must be set before the window is created.
                _title = options.Title;
                _size = options.Size;

                // Set window border.
                switch (options.WindowBorder) {
                    case WindowBorder.Hidden:
                        glfw.WindowHint(WindowHintBool.Decorated, false);
                        glfw.WindowHint(WindowHintBool.Resizable, false);
                        break;

                    case WindowBorder.Resizable:
                        glfw.WindowHint(WindowHintBool.Decorated, true);
                        glfw.WindowHint(WindowHintBool.Resizable, true);
                        break;

                    case WindowBorder.Fixed:
                        glfw.WindowHint(WindowHintBool.Decorated, true);
                        glfw.WindowHint(WindowHintBool.Resizable, false);
                        break;
                }

                _windowBorder = WindowBorder;

                // Set window API.
                switch (options.API.API) {
                    case ContextAPI.None:
                        glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                        break;
                    case ContextAPI.OpenGL:
                        glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
                        break;
                    case ContextAPI.OpenGLES:
                        glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGLES);
                        break;
                }

                // Set API version.
                glfw.WindowHint(WindowHintInt.ContextVersionMajor, options.API.Version.MajorVersion);
                glfw.WindowHint(WindowHintInt.ContextVersionMinor, options.API.Version.MinorVersion);

                // Set API flags
                if (options.API.Flags.HasFlag(ContextFlags.ForwardCompatible)) {
                    glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
                }

                if (options.API.Flags.HasFlag(ContextFlags.Debug)) {
                    glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
                }

                // Set API profile
                glfw.WindowHint(WindowHintOpenGlProfile.OpenGlProfile,
                    options.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat);

                // Create window
                WindowPtr = glfw.CreateWindow(_size.Width, _size.Height, _title, null, null);

                MakeCurrent();

                WindowState = options.WindowState;
                Position = options.Position;
                VSync = options.VSync;

                InitializeCallbacks();
            }
        }

        /// <inheritdoc />
        public void Run()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Close()
        {
            unsafe {
                glfw.SetWindowShouldClose(WindowPtr, true);
            }
        }

        /// <inheritdoc />
        public void ProcessEvents()
        {
            glfw.PollEvents();
        }

        /// <inheritdoc />
        public void SwapBuffers()
        {
            unsafe {
                glfw.SwapBuffers(WindowPtr);
            }
        }

        /// <inheritdoc />
        public void MakeCurrent()
        {
            unsafe {
                glfw.MakeContextCurrent(WindowPtr);
            }
        }

        /// <inheritdoc />
        public Point PointToClient(Point point)
        {
            return new Point(point.X - _position.X, point.Y - _position.Y);
        }

        /// <inheritdoc />
        public Point PointToScreen(Point point)
        {
            return new Point(point.X + _position.X, point.Y + _position.Y);
        }

        // Callbacks

        private GlfwCallbacks.WindowPosCallback onMove;
        private GlfwCallbacks.WindowSizeCallback onResize;
        private GlfwCallbacks.WindowCloseCallback onClosing;
        private GlfwCallbacks.WindowFocusCallback onFocusChanged;
        private GlfwCallbacks.DropCallback onFileDrop;

        /// <summary>
        /// Setup all window callbacks
        /// </summary>
        private unsafe void InitializeCallbacks()
        {
            onMove = (window, x, y) =>
            {
                var point = new Point(x, y);
                _position = point;
                OnMove(point);
            };
            glfw.SetWindowPosCallback(WindowPtr, onMove);
            
            onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                _size = size;
                OnResize(size);
            };
            glfw.SetWindowSizeCallback(WindowPtr, onResize);
            
            onClosing = (window) => OnClosing();
            glfw.SetWindowCloseCallback(WindowPtr, onClosing);
            
            onFocusChanged = (window, isFocused) => OnFocusChanged(isFocused);
            glfw.SetWindowFocusCallback(WindowPtr, onFocusChanged);

            onFileDrop = (window, count, paths) =>
            {
                var pathsStrings = (char**)paths;

                var arrayOfPaths = new string[count];

                for (var i = 0; i < count; i++)
                {
                    if (pathsStrings != null)
                    {
                        arrayOfPaths[i] = new string(pathsStrings[i]);
                    }
                }

                OnFileDrop(arrayOfPaths);
                
            };
            glfw.SetDropCallback(WindowPtr, onFileDrop);
        }

        /// <inheritdoc />
        public virtual void OnMove(Point newPosition)
        {
        }

        /// <inheritdoc />
        public virtual void OnResize(Size newSize)
        {
            
        }

        /// <summary>
        /// Called when the window is about to close.
        /// </summary>
        public virtual void OnClosing()
        {
            
        }

        /// <summary>
        /// Called when the window state is changed.
        /// </summary>
        /// <param name="newState">The new state of the window.</param>
        public virtual void OnWindowStateChanged(WindowState newState)
        {
            
        }

        /// <summary>
        /// Called when the window focus changes.
        /// </summary>
        /// <param name="isFocused">If the window is focused or not.</param>
        public virtual void OnFocusChanged(bool isFocused)
        {
            
        }

        /// <summary>
        /// Called when the window visibility changes.
        /// </summary>
        /// <param name="isVisible">If the window is visible or not.</param>
        public virtual void OnVisibilityChanged(bool isVisible)
        {
            
        }

        /// <summary>
        /// Called when the user drops files onto the window.
        /// </summary>
        /// <param name="files">An array of paths to the files dropped.</param>
        public virtual void OnFileDrop(string[] files)
        {
            
        }
    }
}