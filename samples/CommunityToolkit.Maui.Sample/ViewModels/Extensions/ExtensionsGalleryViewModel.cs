﻿using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Sample.Models;
using CommunityToolkit.Maui.Sample.ViewModels.Extensions;

namespace CommunityToolkit.Maui.Sample.ViewModels.Converters;

public class ExtensionsGalleryViewModel : BaseGalleryViewModel
{
	public ExtensionsGalleryViewModel()
		: base(new[]
		{
			SectionModel.Create<ColorAnimationExtensionsViewModel>(nameof(ColorAnimationExtensions),
				"Extension methods that provide color animations"),
			
			SectionModel.Create<OnScreenSizeExtensionViewModel>("OnScreenSize Markup Extension", 
				"A page demonstrating how to control UI elements on different physical screen sizes."),

		})
	{

	}
}