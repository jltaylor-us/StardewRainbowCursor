// Copyright 2023 Jamie Taylor
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;

namespace RainbowCursor {
    internal record class ColorPalette(
        string Id,
        IManifest ProvidedBy,
        Func<string> GetName,
        List<Color> Colors,
        Func<string?>? GetTitle = null,
        Func<string?>? GetDescription = null);
}

