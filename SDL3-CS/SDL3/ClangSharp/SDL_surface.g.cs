/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    public enum SDL_ScaleMode
    {
        SDL_SCALEMODE_NEAREST,
        SDL_SCALEMODE_LINEAR,
    }

    public enum SDL_FlipMode
    {
        SDL_FLIP_NONE,
        SDL_FLIP_HORIZONTAL,
        SDL_FLIP_VERTICAL,
    }

    public partial struct SDL_Surface
    {
        public SDL_SurfaceFlags flags;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int pitch;

        [NativeTypeName("void*")]
        public IntPtr pixels;

        public int refcount;

        [NativeTypeName("void*")]
        public IntPtr reserved;
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, [NativeTypeName("void*")] IntPtr pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroySurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PropertiesID SDL_GetSurfaceProperties(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Colorspace SDL_GetSurfaceColorspace(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_CreateSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_GetSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SurfaceHasAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface** SDL_GetSurfaceImages(SDL_Surface* surface, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RemoveSurfaceAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_LockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadBMP_IO(SDL_IOStream* src, [NativeTypeName("bool")] SDLBool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadBMP([NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("bool")] SDLBool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SaveBMP(SDL_Surface* surface, [NativeTypeName("const char *")] byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceRLE(SDL_Surface* surface, [NativeTypeName("bool")] SDLBool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SurfaceHasRLE(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("bool")] SDLBool enabled, [NativeTypeName("Uint32")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SurfaceHasColorKey(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, SDL_PropertiesID props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ConvertPixels(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] IntPtr src, int src_pitch, SDL_PixelFormat dst_format, [NativeTypeName("void*")] IntPtr dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, SDL_PropertiesID src_properties, [NativeTypeName("const void *")] IntPtr src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, SDL_PropertiesID dst_properties, [NativeTypeName("void*")] IntPtr dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] IntPtr src, int src_pitch, SDL_PixelFormat dst_format, [NativeTypeName("void*")] IntPtr dst, int dst_pitch, [NativeTypeName("bool")] SDLBool linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_PremultiplySurfaceAlpha(SDL_Surface* surface, [NativeTypeName("bool")] SDLBool linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurfaceUnchecked(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurfaceTiled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurfaceTiledWithScale(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_BlitSurface9Grid(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapSurfaceRGB(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapSurfaceRGBA(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ReadSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_WriteSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern SDLBool SDL_WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);

        [NativeTypeName("#define SDL_SURFACE_PREALLOCATED 0x00000001u")]
        public const uint SDL_SURFACE_PREALLOCATED = 0x00000001U;

        [NativeTypeName("#define SDL_SURFACE_LOCK_NEEDED 0x00000002u")]
        public const uint SDL_SURFACE_LOCK_NEEDED = 0x00000002U;

        [NativeTypeName("#define SDL_SURFACE_LOCKED 0x00000004u")]
        public const uint SDL_SURFACE_LOCKED = 0x00000004U;

        [NativeTypeName("#define SDL_SURFACE_SIMD_ALIGNED 0x00000008u")]
        public const uint SDL_SURFACE_SIMD_ALIGNED = 0x00000008U;

        [NativeTypeName("#define SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT \"SDL.surface.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT => "SDL.surface.SDR_white_point"u8;

        [NativeTypeName("#define SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT \"SDL.surface.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT => "SDL.surface.HDR_headroom"u8;

        [NativeTypeName("#define SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING \"SDL.surface.tonemap\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING => "SDL.surface.tonemap"u8;
    }
}
