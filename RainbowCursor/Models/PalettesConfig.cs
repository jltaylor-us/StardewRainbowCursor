// Copyright 2023 Jamie Taylor
using System;
using System.Collections.Generic;
using StardewModdingAPI;

namespace RainbowCursor.Models {
    public class PalettesConfig {

        public ISemanticVersion? FormatVersion { get; }

        public List<PaletteConfig>? Palettes { get; }

        public PalettesConfig(ISemanticVersion? formatVersion, List<PaletteConfig>? palettes) {
            this.FormatVersion = formatVersion;
            this.Palettes = palettes;
        }

    }
}

