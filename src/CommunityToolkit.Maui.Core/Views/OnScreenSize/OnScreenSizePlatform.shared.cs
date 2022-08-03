using System.Diagnostics.CodeAnalysis;

namespace CommunityToolkit.Maui.Core.Views.OnScreenSize;


#if !(IOS || ANDROID || MACCATALYST || WINDOWS)
/// <summary>
/// Platform-specifics for getting specific screen information.
/// </summary>
public static partial class OnScreenSizePlatform
{
	/// <summary>
	/// Returns how many horizontal/vertical pixels-per-inches the current device screen has.
	/// </summary>
	/// <returns></returns>
	public static bool TryGetPixelPerInches(out double xdpi, out double ydpi)
	{
		throw new NotSupportedException("Platform implementation not found");
	}
}
#endif
