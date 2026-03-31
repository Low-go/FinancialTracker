using MudBlazor;

namespace FinanceTracker.Client.Layout.Theme;

public static class AppTheme
{
    public static MudTheme Theme => new()
    {
        PaletteDark = new PaletteDark()
        {
            Primary = "#C9A84C",
            PrimaryDarken = "rgba(201, 168, 76, 0.18)",

            Secondary = "#2DC6A8",
            SecondaryDarken = "rgba(45, 198, 168, 0.15)",

            Error = "#E05A5A",
            ErrorContrastText = "#F0EDE6",

            Info = "#4D85D1",

            Background = "#0C0F1A",
            BackgroundGray = "#111827",

            Surface = "#1E2A40",

            AppbarBackground = "#111827",
            AppbarText = "#F0EDE6",

            DrawerBackground = "#111827",
            DrawerText = "#8A96A8",
            DrawerIcon = "#8A96A8",

            TextPrimary = "#F0EDE6",
            TextSecondary = "#8A96A8",
            TextDisabled = "#4A5568",

            ActionDefault = "#8A96A8",
            ActionDisabled = "#4A5568",
            ActionDisabledBackground = "rgba(255, 255, 255, 0.07)",

            Divider = "rgba(255, 255, 255, 0.07)",
            DividerLight = "rgba(255, 255, 255, 0.13)",

            TableLines = "rgba(255, 255, 255, 0.07)",
            TableStriped = "rgba(255, 255, 255, 0.03)",
            TableHover = "rgba(255, 255, 255, 0.025)",

            LinesDefault = "rgba(255, 255, 255, 0.07)",
            LinesInputs = "rgba(255, 255, 255, 0.13)",

            OverlayDark = "rgba(0, 0, 0, 0.6)",
            OverlayLight = "rgba(0, 0, 0, 0.3)",
        },

        Typography = new Typography()
        {
            Default = new DefaultTypography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "14px",
                FontWeight = "400",
                LineHeight = "1.5",
            },
            H1 = new H1Typography()
            {
                FontFamily = new[] { "DM Serif Display", "Georgia", "serif" },
                FontSize = "32px",
                FontWeight = "400",
                LineHeight = "1.2",
            },
            H2 = new H2Typography()
            {
                FontFamily = new[] { "DM Serif Display", "Georgia", "serif" },
                FontSize = "26px",
                FontWeight = "400",
                LineHeight = "1.25",
            },
            H3 = new H3Typography()
            {
                FontFamily = new[] { "DM Serif Display", "Georgia", "serif" },
                FontSize = "20px",
                FontWeight = "400",
                LineHeight = "1.3",
            },
            H4 = new H4Typography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "16px",
                FontWeight = "600",
                LineHeight = "1.4",
            },
            H5 = new H5Typography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "14px",
                FontWeight = "600",
                LineHeight = "1.4",
            },
            H6 = new H6Typography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "12px",
                FontWeight = "600",
                LineHeight = "1.4",
            },
            Body1 = new Body1Typography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "14px",
                FontWeight = "400",
                LineHeight = "1.6",
            },
            Body2 = new Body2Typography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "12px",
                FontWeight = "400",
                LineHeight = "1.5",
            },
            Button = new ButtonTypography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "13px",
                FontWeight = "600",
                LineHeight = "1.4",
                LetterSpacing = "0.02em",
            },
            Caption = new CaptionTypography()
            {
                FontFamily = new[] { "DM Mono", "Fira Code", "monospace" },
                FontSize = "11px",
                FontWeight = "400",
                LineHeight = "1.4",
            },
            Overline = new OverlineTypography()
            {
                FontFamily = new[] { "Manrope", "system-ui", "sans-serif" },
                FontSize = "10px",
                FontWeight = "600",
                LineHeight = "1.4",
                LetterSpacing = "0.1em",
            },
        },

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "8px",
            DrawerWidthLeft = "220px",
            AppbarHeight = "60px",
        },
    };
}