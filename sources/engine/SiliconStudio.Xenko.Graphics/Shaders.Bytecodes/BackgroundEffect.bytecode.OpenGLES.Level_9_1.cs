﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [BackgroundEffect]
//
//     Command Line: C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGLES --output-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class BackgroundEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
1, 192, 254, 239, 0, 5, 0, 0, 0, 16, 66, 97, 99, 107, 103, 114, 111, 117, 110, 100, 69, 102, 102, 101, 99, 116, 1, 79, 92, 6, 222, 76, 250, 227, 58, 89, 71, 111, 93, 68, 113, 205, 137, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 29, 34, 58, 164, 137, 37, 104, 112, 102, 62, 
171, 91, 222, 240, 184, 141, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 5, 53, 66, 125, 168, 40, 169, 95, 115, 110, 141, 195, 22, 140, 101, 223, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 67, 
83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 32, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 46, 88, 101, 110, 107, 111, 70, 108, 105, 
112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 0, 21, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 
1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 
102, 111, 114, 109, 0, 0, 0, 0, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 1, 0, 
26, 66, 97, 99, 107, 103, 114, 111, 117, 110, 100, 69, 102, 102, 101, 99, 116, 46, 73, 110, 116, 101, 110, 115, 105, 116, 121, 0, 0, 0, 0, 0, 14, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 
0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 0, 0, 
0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 9, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 12, 83, 97, 
109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 10, 0, 0, 0, 
25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 
21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 
83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 4, 0, 0, 160, 3, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 
97, 114, 103, 101, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 
68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 
32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 
116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 
68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 116, 109, 112, 118, 97, 114, 
95, 49, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 40, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 
10, 10, 246, 3, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 
105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 59, 10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 
111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 10, 32, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 
69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 
10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 
115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 
69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 41, 59, 10, 32, 
32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 40, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 116, 192, 126, 101, 173, 30, 149, 70, 6, 78, 111, 16, 69, 83, 229, 223, 0, 5, 0, 0, 0, 0, 0, 4, 0, 0, 199, 2, 112, 114, 101, 
99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 
114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 
97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 109, 101, 100, 105, 117, 109, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 
95, 50, 32, 61, 32, 40, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 32, 42, 32, 116, 101, 120, 116, 117, 114, 101, 50, 68, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 
84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 41, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 
10, 125, 10, 10, 151, 3, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 
111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 32, 32, 102, 108, 111, 97, 116, 32, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 
51, 59, 10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 10, 32, 32, 102, 108, 111, 97, 116, 32, 88, 101, 110, 107, 111, 70, 108, 105, 112, 82, 101, 110, 100, 
101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 49, 93, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 
101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 
32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 40, 73, 110, 116, 101, 110, 115, 105, 116, 121, 95, 105, 100, 55, 51, 32, 42, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 
112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 10, 183, 181, 158, 
182, 112, 32, 251, 189, 156, 125, 152, 68, 228, 175, 89, 
        };
    }
}
#endif
