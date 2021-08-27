<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/163292254/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830484)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to prevent negative values in numeric editors
 
 
Use the following ways to enter only positive values.
 
1. Configure a numeric [mask](https://docs.devexpress.com/WPF/6945/controls-and-libraries/data-editors/common-features/masked-input).

As you can see in the [Mask Type: Numeric](https://docs.devexpress.com/WPF/6950/controls-and-libraries/data-editors/common-features/masked-input/mask-type-numeric) documentation topic, you can use the ';' symbol to specify different masks for negative and positive values. Your text editor will not allow entering negative values if you make the negative mask empty.

2. Use [SpinEdit](https://docs.devexpress.com/WPF/6163/controls-and-libraries/data-editors/editor-types/spinedit)/[SpinEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.SpinEditSettings) and set the [SpinEdit.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.SpinEdit.MinValue)/[SpinEditSettings.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.SpinEditSettings.MinValue) property.

This editor type is designed for numeric values and provides a ready-to-use **MinValue** property. It also shows the spin up and down buttons, but it's easy to hide them by setting the [ButtonEdit.AllowDefaultButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ButtonEdit.AllowDefaultButton)/[ButtonEditSettings.AllowDefaultButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.ButtonEditSettings.AllowDefaultButton) property.
