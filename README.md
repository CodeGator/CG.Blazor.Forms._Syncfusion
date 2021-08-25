# CG.Blazor.Forms._Syncfusion: 

---
[![Build Status](https://dev.azure.com/codegator/CG.Blazor.Forms._Syncfusion/_apis/build/status/CodeGator.CG.Blazor.Forms._Syncfusion?branchName=main)](https://dev.azure.com/codegator/CG.Blazor.Forms._Syncfusion/_build/latest?definitionId=76&branchName=main)
[![Github docs](https://img.shields.io/static/v1?label=Documentation&message=online&color=blue)](https://codegator.github.io/CG.Blazor.Forms._Syncfusion/index.html)
[![NuGet downloads](https://img.shields.io/nuget/dt/CG.Blazor.Forms._Syncfusion.svg?style=flat)](https://nuget.org/packages/CG.Blazor.Forms._Syncfusion)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/codegator/CG.Blazor.Forms._Syncfusion/76)
[![Github discussion](https://img.shields.io/badge/Discussion-online-blue)](https://github.com/CodeGator/CG.Blazor.Forms._Syncfusion/discussions)
[![CG.Blazor.Forms._Syncfusion on fuget.org](https://www.fuget.org/packages/CG.Blazor.Forms._Syncfusion/badge.svg)](https://www.fuget.org/packages/CG.Blazor.Forms._Syncfusion)

#### What does it do?
The package contains Syncfusion extensions for the CG.Blazor.Forms package.

#### Commonly used types:
* CG.Blazor.Forms.Attributes.SyncfusionAttribute
* CG.Blazor.Forms.Attributes.RenderSfCheckBoxAttribute
* CG.Blazor.Forms.Attributes.RenderSfColorPickerAttribute
* CG.Blazor.Forms.Attributes.RenderSfComboBoxAttribute
* CG.Blazor.Forms.Attributes.RenderSfDatePickerAttribute
* CG.Blazor.Forms.Attributes.RenderSfNumericTextBoxAttribute
* CG.Blazor.Forms.Attributes.RenderSfRadioGroupAttribute
* CG.Blazor.Forms.Attributes.RenderSfSliderAttribute
* CG.Blazor.Forms.Attributes.RenderSfTextBoxAttribute
* CG.Blazor.Forms.Attributes.RenderSfTimePickerAttributre

#### What platform(s) does it support?
* .NET 5.x or higher

#### How do I install it?
The binary is hosted on [NuGet](https://www.nuget.org/packages/CG.Blazor.Forms._Syncfusion). To install the package using the NuGet package manager:

PM> Install-Package CG.Blazor.Forms._Syncfusion

#### How do I contact you?
If you've spotted a bug in the code please use the project Issues [HERE](https://github.com/CodeGator/CG.Blazor.Forms._Syncfusion/issues)

We have a discussion group [HERE](https://github.com/CodeGator/CG.Blazor.Forms._Syncfusion/discussions)

#### Is there any documentation?
There is developer documentation [HERE](https://codegator.github.io/CG.Blazor.Forms._Syncfusion/)

We also blog about projects like this one on our website, [HERE](http://www.codegator.com)

---

#### How do I get started?

There is a working quick start sample [HERE](https://github.com/CodeGator/CG.Blazor.Forms._Syncfusion/tree/main/samples/CG.Blazor.Forms._Syncfusion.QuickStart) 

Steps to get started:

1. Create a Blazor project to get started.

2. Add support for Syncfusion Blazor. [HERE](https://blazor.syncfusion.com/documentation/getting-started/blazor-server-side-visual-studio-2019) are instructions for doing that.

3. Add the CG.Blazor.Forms._Syncfusion NUGET package to the project.

4. Add `@using CG.Blazor.Forms.Attributes` to the _Imports.razor file.

5. Add `<DynamicForm Model="@Model" OnValidSubmit="OnValidSubmit"/>` to the razor component where you want your dynamic form generated. Note that `Model` is a reference to your POCO object, and `OnValidSubmit` is a reference to your form's submit handler.

6. Add `services.AddFormGeneration();` to the `ConfigureServices` method of the `Startup` class.

7. Create your model type. Use attributes from the NUGET package to decorate any properties you want to be rendered on the form. Here is an example:

```
[RenderValidationSummary()]
[RenderFluentValidationValidator]
public class MyForm
{
	[RenderSfTextBox]
	[Required]
	public string FirstName { get; set; }

	[RenderSfTextBox]
	[Required]
	public string LastName { get; set; }
}
```

That's pretty much it! You can, of course, get fancier, but that's up to you.




