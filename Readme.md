<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/163292254/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830484)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Editors - Allow Users to Enter Only Positive Numbers

This example demonstrates how to allow users to enter only positive numbers in [WPF Data Editors](https://docs.devexpress.com/WPF/6190/controls-and-libraries/data-editors).

![image](https://user-images.githubusercontent.com/65009440/220624352-8e85574a-d3e9-476a-bcb5-74897baca85d.png)

You can use one of the following techniques:
 
* Configure a numeric [mask](https://docs.devexpress.com/WPF/6945/controls-and-libraries/data-editors/common-features/masked-input).

  Use the semicolon (`;`) symbol to specify different masks for positive and negative values. If the negative mask is empty, the text editor does not allow users to enter negative values:
  
  ```
  <dxe:TextEdit Mask="##0;" MaskType="Numeric" MaskUseAsDisplayFormat="True"/>
  ```

* Use the [SpinEdit](https://docs.devexpress.com/WPF/6163/controls-and-libraries/data-editors/editor-types/spinedit) / [SpinEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.SpinEditSettings) and specify the [SpinEdit.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.SpinEdit.MinValue) / [SpinEditSettings.MinValue](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.SpinEditSettings.MinValue) property:

  ```
  <dxe:SpinEdit MinValue="0" AllowRoundOutOfRangeValue="True"/>
  ```

  You can also set the [ButtonEdit.AllowDefaultButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ButtonEdit.AllowDefaultButton) / [ButtonEditSettings.AllowDefaultButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.ButtonEditSettings.AllowDefaultButton) property to `false` to hide the editor's spin up and down buttons.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml)

## Documentation

* [Numeric Masks](https://docs.devexpress.com/WPF/6950/controls-and-libraries/data-editors/common-features/masked-input/mask-type-numeric)
* [SpinEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.SpinEdit)
* [SpinEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.SpinEditSettings)
* [Assign Editors to Cells](https://docs.devexpress.com/WPF/401011/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/assign-an-editor-to-a-cell)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-editors-prevent-negative-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-editors-prevent-negative-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
