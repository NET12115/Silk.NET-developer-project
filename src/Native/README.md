# Native Packages
This folder contains NuGet distributions of the binaries for the various libraries we bind to. Previously, this had its
own repository, but was coalesced into this repository to be reunited with the rest of Silk.NET.

In 3.0 we intend to move the packages to use the Silk.NET.\* prefix instead of old Ultz.\* prefix. The folder and
project file names reflect this change today, but still use the old package IDs within them. The mapping of the old
package IDs to the new project is as follows:

- Ultz.Native.Assimp - Silk.NET.Assimp.Native
- Ultz.Native.GLFW - Silk.NET.GLFW.Native
- Ultz.Native.SDL - Silk.NET.SDL.Native

Each binary distribution inherits the license from the library contained within it, and you should check it for
compatibility with the rest of your solution:

- Silk.NET.Assimp.Native: BSD-3-Clause
- Silk.NET.SDL.Native and Silk.NET.GLFW.Native: Zlib
