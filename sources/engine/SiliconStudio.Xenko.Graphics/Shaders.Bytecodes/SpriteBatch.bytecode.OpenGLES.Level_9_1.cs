﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SpriteBatch]
//
//     Command Line: C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGLES --output-path=C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\DEV\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    public partial class SpriteBatch
    {
        private static readonly byte[] binaryBytecode = new byte[] {
1, 192, 254, 239, 0, 6, 0, 0, 0, 17, 83, 112, 114, 105, 116, 101, 66, 97, 116, 99, 104, 83, 104, 97, 100, 101, 114, 1, 26, 42, 173, 201, 7, 31, 84, 101, 160, 181, 61, 143, 36, 194, 120, 155, 10, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 1, 24, 122, 117, 12, 177, 182, 110, 250, 252, 
51, 21, 105, 61, 219, 225, 104, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 76, 31, 25, 215, 193, 29, 168, 182, 119, 159, 125, 91, 210, 35, 12, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 
67, 83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 77, 232, 0, 156, 217, 55, 64, 161, 231, 217, 185, 133, 139, 109, 6, 40, 0, 0, 
2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 0, 0, 0, 0, 1, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 
50, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 64, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 1, 0, 7, 80, 101, 114, 68, 114, 97, 119, 64, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 27, 84, 
101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 1, 0, 0, 0, 3, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 
117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 
101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 
0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 
105, 122, 101, 95, 105, 100, 50, 48, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 24, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 
101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 50, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 
0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 1, 0, 
0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 40, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 
1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 48, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 
117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 
56, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 
56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 48, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 
117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 0, 0, 0, 1, 0, 22, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 72, 0, 0, 0, 1, 0, 0, 0, 8, 0, 
0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 80, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 0, 0, 0, 0, 1, 0, 13, 
84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 9, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 1, 0, 12, 83, 97, 109, 112, 108, 
101, 114, 95, 105, 100, 52, 49, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 0, 0, 0, 0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 25, 0, 
0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 
0, 0, 1, 0, 0, 0, 0, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 17, 84, 101, 120, 
116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 8, 0, 0, 148, 4, 117, 110, 105, 102, 111, 114, 109, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 
115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 
48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 
116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 
99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 
32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 
97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 
90, 90, 76, 69, 48, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 
46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 10, 10, 244, 6, 35, 
118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 48, 84, 
101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 
101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 48, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 
83, 105, 122, 101, 95, 105, 100, 50, 50, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 
122, 101, 95, 105, 100, 50, 54, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 
95, 105, 100, 51, 48, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 59, 10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 
80, 101, 114, 68, 114, 97, 119, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 125, 59, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 111, 117, 116, 
32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 
78, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 
79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 104, 105, 103, 104, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 40, 97, 95, 80, 79, 83, 73, 
84, 73, 79, 78, 48, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 119, 59, 10, 32, 
32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 32, 32, 118, 
95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 
45, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 230, 54, 31, 51, 48, 133, 237, 147, 116, 65, 165, 16, 213, 57, 128, 32, 0, 5, 0, 0, 0, 0, 0, 8, 
0, 0, 138, 5, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 
101, 114, 95, 105, 100, 52, 49, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 
118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 109, 101, 100, 105, 117, 109, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 
59, 10, 32, 32, 118, 101, 99, 50, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 
116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 52, 59, 10, 32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 
69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 
48, 59, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 50, 68, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 
79, 82, 68, 48, 41, 59, 10, 32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 50, 68, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 
114, 95, 105, 100, 52, 49, 44, 32, 116, 109, 112, 118, 97, 114, 95, 50, 41, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 53, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 53, 32, 61, 32, 
40, 116, 109, 112, 118, 97, 114, 95, 52, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 51, 41, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 53, 59, 10, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 
32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 125, 10, 10, 231, 7, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 
100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 
120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 
117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 48, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 50, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 
101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 55, 
84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 48, 59, 10, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 
120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 59, 10, 125, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 80, 101, 114, 68, 114, 97, 119, 32, 123, 10, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 
114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 59, 10, 125, 59, 10, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 49, 93, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 
114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 
67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 118, 101, 99, 50, 32, 116, 109, 112, 118, 97, 114, 95, 49, 
59, 10, 32, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 118, 95, 67, 79, 76, 79, 
82, 48, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 
32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 
32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 
32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 116, 109, 112, 118, 97, 114, 95, 49, 41, 46, 120, 120, 120, 
120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 40, 116, 109, 112, 118, 97, 114, 95, 51, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 50, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 1, 246, 7, 14, 26, 162, 15, 185, 84, 187, 49, 19, 247, 54, 116, 11, 71, 
        };
    }
}
#endif
