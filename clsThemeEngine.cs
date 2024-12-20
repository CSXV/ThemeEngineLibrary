using MaterialColorUtilities.Palettes;
using MaterialColorUtilities.Schemes;
using System.Drawing;

namespace ThemeEngineLibrary {
  public class clsThemeEngine {
    public uint color { get; set; }

    public Scheme<uint> Scheme { get; private set; }
    public CorePalette corePalette { get; private set; }

    public Color Primary { get; private set; }
    public Color OnPrimary { get; private set; }
    public Color InversePrimary { get; private set; }
    public Color PrimaryContainer { get; private set; }
    public Color OnPrimaryContainer { get; private set; }

    public Color Secondary { get; private set; }
    public Color OnSecondary { get; private set; }
    public Color SecondaryContainer { get; private set; }
    public Color OnSecondaryContainer { get; private set; }

    public Color Tertiary { get; private set; }
    public Color OnTertiary { get; private set; }
    public Color TertiaryContainer { get; private set; }
    public Color OnTertiaryContainer { get; private set; }


    public Color Neutral { get; private set; }
    public Color NeutralVariant { get; private set; }

    public Color Error { get; private set; }
    public Color OnError { get; private set; }
    public Color ErrorContainer { get; private set; }
    public Color OnErrorContainer { get; private set; }

    public Color Background { get; private set; }
    public Color OnBackground { get; private set; }
    public Color Shadow { get; private set; }

    public Color Surface { get; private set; }
    public Color OnSurface { get; private set; }
    public Color InverseSurface { get; private set; }
    public Color InverseOnSurface { get; private set; }
    public Color SurfaceVariant { get; private set; }
    public Color OnSurfaceVariant { get; private set; }

    public Color Surface1 { get; private set; }
    public Color Surface2 { get; private set; }
    public Color Surface3 { get; private set; }
    public Color Surface4 { get; private set; }
    public Color Surface5 { get; private set; }

    public Color SurfaceBright { get; private set; }
    public Color SurfaceDim { get; private set; }
    public Color SurfaceContainer { get; private set; }
    public Color SurfaceContainerLow { get; private set; }
    public Color SurfaceContainerLowest { get; private set; }
    public Color SurfaceContainerHigh { get; private set; }
    public Color SurfaceContainerHighest { get; private set; }

    public clsThemeEngine(uint color) {
      this.color = color;

      _GenerateThemePalette();
    }

    public clsThemeEngine(Color c) {
      this.color = (uint)(c.R << 16 | c.G << 8 | c.B);

      _GenerateThemePalette();
    }

    public void UpdateScheme(Color c) {
      this.color = (uint)(c.R << 16 | c.G << 8 | c.B);

      _GenerateThemePalette();
    }

    public void UpdateScheme(uint c) {
      this.color = c;

      _GenerateThemePalette();
    }

    private void _GenerateThemePalette() {
      _GenCorePalette();
      _GenScheme();
      _GenPalettes();
    }

    private void _GenCorePalette() {
      this.corePalette = CorePalette.Of(this.color);
    }

    private void _GenScheme() {
      Scheme<uint> scheme = new DarkSchemeMapper().Map(corePalette);
      this.Scheme = scheme;
    }

    private void _GenPalettes() {
      uint neutral = corePalette.Neutral[40];
      uint neutralvariant = corePalette.NeutralVariant[40];

      // Primary
      this.Primary = Color.FromArgb((int)Scheme.Primary);
      this.OnPrimary = Color.FromArgb((int)Scheme.OnPrimary);
      this.PrimaryContainer = Color.FromArgb((int)Scheme.PrimaryContainer);
      this.InversePrimary = Color.FromArgb((int)Scheme.InversePrimary);
      this.OnPrimaryContainer = Color.FromArgb((int)Scheme.OnPrimaryContainer);

      // Secondary
      this.Secondary = Color.FromArgb((int)Scheme.Secondary);
      this.SecondaryContainer = Color.FromArgb((int)Scheme.SecondaryContainer);
      this.OnSecondary = Color.FromArgb((int)Scheme.OnSecondary);
      this.OnSecondaryContainer =
          Color.FromArgb((int)Scheme.OnSecondaryContainer);

      // Tertiary
      this.Tertiary = Color.FromArgb((int)Scheme.Tertiary);
      this.OnTertiary = Color.FromArgb((int)Scheme.OnTertiary);
      this.TertiaryContainer = Color.FromArgb((int)Scheme.TertiaryContainer);
      this.OnTertiaryContainer = Color.FromArgb((int)Scheme.OnTertiaryContainer);

      // Neutral
      this.Neutral = Color.FromArgb((int)neutral);
      this.NeutralVariant = Color.FromArgb((int)neutralvariant);

      // Background
      this.Background = Color.FromArgb((int)Scheme.Background);
      this.OnBackground = Color.FromArgb((int)Scheme.OnBackground);
      this.Shadow = Color.FromArgb((int)Scheme.Shadow);

      // Error
      this.Error = Color.FromArgb((int)Scheme.Error);
      this.OnError = Color.FromArgb((int)Scheme.OnError);
      this.ErrorContainer = Color.FromArgb((int)Scheme.ErrorContainer);
      this.OnErrorContainer = Color.FromArgb((int)Scheme.OnErrorContainer);

      // Surface
      this.Surface = Color.FromArgb((int)Scheme.Surface);
      this.OnSurface = Color.FromArgb((int)Scheme.OnSurface);
      this.SurfaceVariant = Color.FromArgb((int)Scheme.SurfaceVariant);
      this.OnSurfaceVariant = Color.FromArgb((int)Scheme.OnSurfaceVariant);
      this.InverseSurface = Color.FromArgb((int)Scheme.InverseSurface);
      this.InverseOnSurface = Color.FromArgb((int)Scheme.InverseOnSurface);

      this.Surface1 = Color.FromArgb((int)Scheme.Surface1);
      this.Surface2 = Color.FromArgb((int)Scheme.Surface2);
      this.Surface3 = Color.FromArgb((int)Scheme.Surface3);
      this.Surface4 = Color.FromArgb((int)Scheme.Surface4);
      this.Surface5 = Color.FromArgb((int)Scheme.Surface5);

      this.SurfaceBright = Color.FromArgb((int)Scheme.SurfaceBright);
      this.SurfaceDim = Color.FromArgb((int)Scheme.SurfaceDim);

      this.SurfaceContainerLow = Color.FromArgb((int)Scheme.SurfaceContainerLow);
      this.SurfaceContainerLowest =
      this.SurfaceContainer = Color.FromArgb((int)Scheme.SurfaceContainer);
      Color.FromArgb((int)Scheme.SurfaceContainerLowest);
      this.SurfaceContainerHigh =
          Color.FromArgb((int)Scheme.SurfaceContainerHigh);
      this.SurfaceContainerHighest =
          Color.FromArgb((int)Scheme.SurfaceContainerHighest);
    }

    // uint primary = corepalette.Tertiary[x];

    // Scheme<string> schemeString = scheme.Convert(x => "#" + x.ToString("x6"));
    // Scheme<Color> schemeColor = scheme.Convert(Color.FromUint);

    // return Color.FromArgb((int)scheme.Primary);
    // return Color.FromArgb((int)primary);
  }
}
