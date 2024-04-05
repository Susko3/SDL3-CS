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
    public enum SDL_DUMMY_ENUM
    {
        DUMMY_ENUM_VALUE,
    }

    public partial struct SDL_iconv_data_t
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_malloc([NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_realloc(void* mem, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetOriginalMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetMemoryFunctions([NativeTypeName("SDL_malloc_func *")] delegate* unmanaged[Cdecl]<nuint, void*>* malloc_func, [NativeTypeName("SDL_calloc_func *")] delegate* unmanaged[Cdecl]<nuint, nuint, void*>* calloc_func, [NativeTypeName("SDL_realloc_func *")] delegate* unmanaged[Cdecl]<void*, nuint, void*>* realloc_func, [NativeTypeName("SDL_free_func *")] delegate* unmanaged[Cdecl]<void*, void>* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] delegate* unmanaged[Cdecl]<nuint, void*> malloc_func, [NativeTypeName("SDL_calloc_func")] delegate* unmanaged[Cdecl]<nuint, nuint, void*> calloc_func, [NativeTypeName("SDL_realloc_func")] delegate* unmanaged[Cdecl]<void*, nuint, void*> realloc_func, [NativeTypeName("SDL_free_func")] delegate* unmanaged[Cdecl]<void*, void> free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_aligned_alloc([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_aligned_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_getenv([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_setenv([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_qsort(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, int> compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_qsort_r(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(void *, const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_bsearch_r([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(void *, const void *, const void *)")] delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_abs(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalpha(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalnum(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isblank(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iscntrl(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isxdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ispunct(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isspace(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_islower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isprint(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isgraph(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_toupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_tolower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_crc16([NativeTypeName("Uint16")] ushort crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_crc32([NativeTypeName("Uint32")] uint crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memcpy(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memmove(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memset(void* dst, int c, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memset4(void* dst, [NativeTypeName("Uint32")] uint val, [NativeTypeName("size_t")] nuint dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_memcmp([NativeTypeName("const void *")] void* s1, [NativeTypeName("const void *")] void* s2, [NativeTypeName("size_t")] nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_wcslen([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_wcsnlen([NativeTypeName("const wchar_t *")] ushort* wstr, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_wcslcpy([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_wcslcat([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsdup([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsnstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_wcstol([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_strnlen([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_utf8strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_strlcat([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strdup([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strndup([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strrev([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strupr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strlwr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strrchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strstr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strnstr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strcasestr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strtok_r([NativeTypeName("char *")] sbyte* s1, [NativeTypeName("const char *")] sbyte* s2, [NativeTypeName("char **")] sbyte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_utf8strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_utf8strnlen([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_itoa(int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_uitoa([NativeTypeName("unsigned int")] uint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ltoa([NativeTypeName("long")] int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ultoa([NativeTypeName("unsigned long")] uint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_lltoa([NativeTypeName("Sint64")] long value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ulltoa([NativeTypeName("Uint64")] ulong value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_atoi([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atof([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_strtol([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint SDL_strtoul([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long SDL_strtoll([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_strtoull([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_strtod([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_sscanf([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_vsscanf([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_snprintf([NativeTypeName("char *")] sbyte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_swprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_vsnprintf([NativeTypeName("char *")] sbyte* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_vswprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] nuint maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, [NativeTypeName("va_list")] sbyte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_asprintf([NativeTypeName("char **")] sbyte** strp, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_vasprintf([NativeTypeName("char **")] sbyte** strp, [NativeTypeName("const char *")] sbyte* fmt, [NativeTypeName("va_list")] sbyte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_acos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_acosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_asin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_asinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan2(double y, double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atan2f(float y, float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_ceil(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_ceilf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_copysign(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_copysignf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_cos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_cosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_exp(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_expf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fabs(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fabsf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_floor(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_floorf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_trunc(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_truncf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fmod(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fmodf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_logf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log10(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_log10f(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_modf(double x, double* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_modff(float x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_pow(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_powf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_round(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_roundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_lroundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_scalbn(double x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_scalbnf(float x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sqrt(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sqrtf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_tan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_tanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_iconv_t")]
        public static extern SDL_iconv_data_t* SDL_iconv_open([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iconv_close([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint SDL_iconv([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd, [NativeTypeName("const char **")] sbyte** inbuf, [NativeTypeName("size_t *")] nuint* inbytesleft, [NativeTypeName("char **")] sbyte** outbuf, [NativeTypeName("size_t *")] nuint* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_iconv_string([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode, [NativeTypeName("const char *")] sbyte* inbuf, [NativeTypeName("size_t")] nuint inbytesleft);

        public static int SDL_size_mul_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            if (a != 0 && b > 0xffffffffffffffffUL / a)
            {
                return -1;
            }

            *ret = a * b;
            return 0;
        }

        public static int SDL_size_add_overflow([NativeTypeName("size_t")] nuint a, [NativeTypeName("size_t")] nuint b, [NativeTypeName("size_t *")] nuint* ret)
        {
            if (b > 0xffffffffffffffffUL - a)
            {
                return -1;
            }

            *ret = a + b;
            return 0;
        }

        [NativeTypeName("#define SDL_SIZE_MAX SIZE_MAX")]
        public const ulong SDL_SIZE_MAX = 0xffffffffffffffffUL;

        [NativeTypeName("#define SDL_FALSE 0")]
        public const int SDL_FALSE = 0;

        [NativeTypeName("#define SDL_TRUE 1")]
        public const int SDL_TRUE = 1;

        [NativeTypeName("#define SDL_MAX_SINT8 ((Sint8)0x7F)")]
        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        [NativeTypeName("#define SDL_MIN_SINT8 ((Sint8)(~0x7F))")]
        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        [NativeTypeName("#define SDL_MAX_UINT8 ((Uint8)0xFF)")]
        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        [NativeTypeName("#define SDL_MIN_UINT8 ((Uint8)0x00)")]
        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        [NativeTypeName("#define SDL_MAX_SINT16 ((Sint16)0x7FFF)")]
        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        [NativeTypeName("#define SDL_MIN_SINT16 ((Sint16)(~0x7FFF))")]
        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        [NativeTypeName("#define SDL_MAX_UINT16 ((Uint16)0xFFFF)")]
        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        [NativeTypeName("#define SDL_MIN_UINT16 ((Uint16)0x0000)")]
        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        [NativeTypeName("#define SDL_MAX_SINT32 ((Sint32)0x7FFFFFFF)")]
        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        [NativeTypeName("#define SDL_MIN_SINT32 ((Sint32)(~0x7FFFFFFF))")]
        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        [NativeTypeName("#define SDL_MAX_UINT32 ((Uint32)0xFFFFFFFFu)")]
        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_MIN_UINT32 ((Uint32)0x00000000)")]
        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));

        [NativeTypeName("#define SDL_MAX_SINT64 ((Sint64)0x7FFFFFFFFFFFFFFFll)")]
        public const long SDL_MAX_SINT64 = ((long)(0x7FFFFFFFFFFFFFFFL));

        [NativeTypeName("#define SDL_MIN_SINT64 ((Sint64)(~0x7FFFFFFFFFFFFFFFll))")]
        public const long SDL_MIN_SINT64 = ((long)(~0x7FFFFFFFFFFFFFFFL));

        [NativeTypeName("#define SDL_MAX_UINT64 ((Uint64)0xFFFFFFFFFFFFFFFFull)")]
        public const ulong SDL_MAX_UINT64 = ((ulong)(0xFFFFFFFFFFFFFFFFUL));

        [NativeTypeName("#define SDL_MIN_UINT64 ((Uint64)(0x0000000000000000ull))")]
        public const ulong SDL_MIN_UINT64 = ((ulong)(0x0000000000000000UL));

        [NativeTypeName("#define SDL_MAX_TIME SDL_MAX_SINT64")]
        public const long SDL_MAX_TIME = ((long)(0x7FFFFFFFFFFFFFFFL));

        [NativeTypeName("#define SDL_MIN_TIME SDL_MIN_SINT64")]
        public const long SDL_MIN_TIME = ((long)(~0x7FFFFFFFFFFFFFFFL));

        [NativeTypeName("#define SDL_FLT_EPSILON 1.1920928955078125e-07F")]
        public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

        [NativeTypeName("#define SDL_PRIs64 \"lld\"")]
        public static ReadOnlySpan<byte> SDL_PRIs64 => "lld"u8;

        [NativeTypeName("#define SDL_PRIu64 \"llu\"")]
        public static ReadOnlySpan<byte> SDL_PRIu64 => "llu"u8;

        [NativeTypeName("#define SDL_PRIx64 \"llx\"")]
        public static ReadOnlySpan<byte> SDL_PRIx64 => "llx"u8;

        [NativeTypeName("#define SDL_PRIX64 \"llX\"")]
        public static ReadOnlySpan<byte> SDL_PRIX64 => "llX"u8;

        [NativeTypeName("#define SDL_PRIs32 \"d\"")]
        public static ReadOnlySpan<byte> SDL_PRIs32 => "d"u8;

        [NativeTypeName("#define SDL_PRIu32 \"u\"")]
        public static ReadOnlySpan<byte> SDL_PRIu32 => "u"u8;

        [NativeTypeName("#define SDL_PRIx32 \"x\"")]
        public static ReadOnlySpan<byte> SDL_PRIx32 => "x"u8;

        [NativeTypeName("#define SDL_PRIX32 \"X\"")]
        public static ReadOnlySpan<byte> SDL_PRIX32 => "X"u8;

        [NativeTypeName("#define SDL_PI_D 3.141592653589793238462643383279502884")]
        public const double SDL_PI_D = 3.141592653589793238462643383279502884;

        [NativeTypeName("#define SDL_PI_F 3.141592653589793238462643383279502884F")]
        public const float SDL_PI_F = 3.141592653589793238462643383279502884F;

        [NativeTypeName("#define SDL_ICONV_ERROR (size_t)-1")]
        public static readonly nuint SDL_ICONV_ERROR = unchecked((nuint)(-1));

        [NativeTypeName("#define SDL_ICONV_E2BIG (size_t)-2")]
        public static readonly nuint SDL_ICONV_E2BIG = unchecked((nuint)(-2));

        [NativeTypeName("#define SDL_ICONV_EILSEQ (size_t)-3")]
        public static readonly nuint SDL_ICONV_EILSEQ = unchecked((nuint)(-3));

        [NativeTypeName("#define SDL_ICONV_EINVAL (size_t)-4")]
        public static readonly nuint SDL_ICONV_EINVAL = unchecked((nuint)(-4));
    }
}
