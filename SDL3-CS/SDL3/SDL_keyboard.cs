﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;

namespace SDL
{
    [Typedef]
    public enum SDL_KeyboardID : UInt32;

    public partial struct SDL_Keysym
    {
        public SDL_Keymod Mod => (SDL_Keymod)mod;
    }
}
