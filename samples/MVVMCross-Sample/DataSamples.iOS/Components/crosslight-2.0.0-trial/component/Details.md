# Introduction to Crosslight #

This Crosslight component is a fully-featured commercial component with 30 days Crosslight Project Wizard trial.

###What's New###
Built upon the solid foundation laid in the initial version, Crosslight 2 is expanding its already powerful toolset with over 200 new features packed in dozens of new services and components that work reliably across all the supported platforms. Crosslight 2 delivers great business-oriented features including comprehensive data and entity services, offline support, data synchronization, timezone management, authentication, social integration, push notifications, and much more.
With Crosslight 2, you can now build cross-platform enterprise mobile apps that leverage advanced capabilities in dramatically less time with very minimal code, shaving off months of your time table.
Features include:

##Crosslight 2 At a Glance##
* [Crosslight Enterprise App Framework](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-CrosslightEnterpriseAppFramewor]k)
* [Data Access Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-DataAccessServices)
* [Advanced Entity Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-AdvancedEntityServices)
* [Entity Designer for Visual Studio](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-EntityDesignerforVisualStudio)
* [LINQ-enabled SQLite Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-LINQ-enabledSQLiteServices)
* [Enterprise Reporting Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-EnterpriseReportingServices)
* [Push Notification Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-PushNotificationServices)
* [Social Network Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-SocialNetworkServices)
* [Async Image Loader Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-AsyncImageLoaderServices)
* [More Services](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-MoreServices)

##New UI Components##
* [Full-featured Drawer Navigation](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-Full-featuredDrawerNavigation)
* [Advanced Master Detail View](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-AdvancedMasterDetailView)
* [Pull-to-Refresh](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-Pull-to-Refresh)
* [Incremental Loading](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-IncrementalLoading)
* [Async-ready Image View](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-Async-readyImageView)
* [Improved Form Builder](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-ImprovedFormBuilder)

##New Project Templates##
* [Business App Template](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-BusinessAppTemplate)
* [Navigation Drawer Template](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-NavigationDrawerTemplate)

##New Samples##
* [Inventory WebAPI Sample](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-InventoryWebAPISample)
* [Master Detail View with Drawer Sample](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-MasterDetailViewwithDrawerSample)
* [Reporting Services Sample](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-ReportingServicesSample)
* [Project and Task List Sample](http://developer.intersoftpt.com/display/crosslight/Crosslight+2.0+Release+Notes#Crosslight2.0ReleaseNotes-ProjectandTaskListSample)

##Intersoft Developer Center##
Introducing [Intersoft Developer Center](http://developer.intersoftpt.com), a one-stop portal for all your development needs. Featuring comprehensive and detailed documentation, plethora of samples and video tutorials, the Developer Center aims to answer all your questions about Crosslight.  


##Overview##

Leveraging extensible architecture, MVVM design pattern and integration with Xamarin Platforms, Crosslight lets you easily build powerful iOS, Android and Windows native apps with a common application codebase including domain model, data access, and user interaction logic. And that's nearly 96% of your project's codebase. Built with cutting-edge portable framework and MVVM pattern, Crosslight lets you build cross-platform mobile apps by leveraging the programming skills and tools you loved – such as C#, MVVM, .NET and Visual Studio.
Key features include:

*   Comprehensive and advanced mobile frameworks leveraging MVVM design pattern
*   Build native iOS, Android, Windows Phone 8 and Windows 8 apps with a single application codebase
*	Elegant, developer-friendly API based on platform standards
*	Universal data management with automatic binding
*	Streamlined navigation services supporting push, modal and nested navigation mode
*	Rich form builder with 20+ pre-built editors
*	Highly customizable editor controls ranging from auto resize textbox to image picker with camera support and more
*	Comprehensive mobile services for business apps
*	Native user experiences conforming to platform design guidelines
*	Support Visual Studio 2012 and Xamarin Studio
*	Integrated to Xamarin platforms with full AOT compliance
*	Time-saving Project Wizard featuring 30+ templates variants supporting iOS, Android, Windows Phone 8 and Windows 8

##Important!##
If you have purchased a the Crosslight component from the Xamarin Component Store, send us an email of your purchase details to sales@intersoftpt.com for further assistance.

# Sample Code #
Creating a data form editor in all platforms. When users tapped on the Save button, it will perform data saving, show a toast presenter and navigates back to the previous screen.

## Shared Application Project ##

Powered by Crosslight Foundation, the shared application project contains shareable code that can be easily consumed on each platform. Shareable code includes various user interaction logic, reusable ViewModel classes, domain models, data access layers, and more.

### Form Metadata: ###
The Form Metadata is a part of the form builder feature introduced in Crosslight; just by defining the metadata, you can easily create beautiful-looking forms complete with custom data validation and rich editing features.
```csharp
	using Intersoft.Crosslight;
	using Intersoft.Crosslight.Forms;
	using MyInventory.ViewModels;
	using System;
	
	namespace MyInventory.Models
	{
	    [FormMetadataType(typeof(Item.FormMetadata))]
	    partial class Item
	    {
			[Form(Title = "{FormState} Item")]
	        public class FormMetadata
	        {
	            [Section(Style = SectionLayoutStyle.ImageWithFields)]
	            public static GeneralSection General;
	
	            [Section("Item Details")]
	            public static ItemDetailSection ItemDetail;
	
				[Section("Item Status")]
				[VisibilityBinding(Path = "IsNewItem", SourceType = BindingSourceType.ViewModel, ConverterType=typeof(BooleanNegateConverter))]
				public static SoldSection Sold;
	
	            [Section]
	            public static NotesSection Notes;
	        }
	
	        public class GeneralSection
	        {
	            [Editor(EditorType.Image)]
	            [Image(Height = 83, Width = 80, Placeholder = "item_placeholder.png", Frame = "frame.png", FramePadding = 6, FrameShadowHeight = 3)]
	            [ImagePicker(ImageResultMode = ImageResultMode.Both, ActivateCommand = "ActivateImagePickerCommand", PickerResultCommand = "FinishImagePickerCommand")]
	            public static byte[] ThumbnailImage;
	
				[StringInput(Placeholder = "Product name")]
				[Layout(Style = LayoutStyle.DetailOnly)]
	            public static string Name;
	
				[StringInput(Placeholder = "Price")]
				[Layout(Style = LayoutStyle.DetailOnly)]
				public static decimal Price;
			}
	
	        public class ItemDetailSection
	        {
	            ...
	        }
	
			//Define other sections and properties
	        public class ActionSection
	        {
	            ...
	        }
	    }
	}
```
### View Model ###
The ViewModel class contains shareable user interaction logic as well as interaction with the model, for instances performing navigation, showing a message presenter, and more. The ViewModel class will be then consumed by native views on each platform. 
```csharp
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Windows.Input;
	using Intersoft.Crosslight;
	using Intersoft.Crosslight.Forms;
	using Intersoft.Crosslight.Input;
	using Intersoft.Crosslight.ViewModels;
	using MyInventory.Infrastructure;
	using MyInventory.ModelServices;
	using MyInventory.Models;
	
	namespace MyInventory.ViewModels
	{
	    public class ItemEditorViewModel : EditorViewModelBase<Item>
	    {
	        public ItemEditorViewModel()
	        {
	           ...
	        }
	
	        public override void Navigated(NavigatedParameter parameter)
	        {
	            base.Navigated(parameter);
	
	            if (parameter.Data != null)
	            {
	                this.Item = parameter.Data as Item;
	            }
	            else
	            {
	                this.Item = new Item();
					this.Item.PurchaseDate = DateTime.Today;
					this.Item.Quantity = 1;
					this.Item.Category = this.Categories.ElementAt(0);
	
	                this.IsNewItem = true;
	                this.Title = "Add New Item";
	            }
	        }

	        protected override void ExecuteSave(object parameter)
	        {
	            this.Validate();
	
	            if (!this.HasErrors)
	            {
					if (this.IsDirty)
					{
		                if (this.IsNewItem)
						{
							this.ItemRepository.Insert(this.Item);
						}
						else
						{
							this.ItemRepository.Update(this.Item);
							this.OnDataChanged(this.Item);
						}
	
						// show quick status
						this.ToastPresenter.Show("Changes saved", ToastDisplayDuration.Immediate);
					}
	
					this.IsDirty = false;
	
					 this.ItemRepository.SaveChanges(null, null);
	
	                this.NavigationService.Close(new NavigationResult(NavigationResultAction.Done));
	            }
				else
				{
					this.ShowErrorMessage();
				}
	        }
	
			...
	    }
	}	
```
## iOS ##
Consuming the Form Metadata from the view model on iOS:
```csharp
	using Intersoft.Crosslight.iOS;
	using MyInventory.ViewModels;
	
	namespace MyInventory.iOS
	{
	    public partial class ItemEditViewController : UIFormViewController<ItemEditorViewModel>
	    {
	    }
	}
```

## Android ##
Consuming the Form Metadata from the view model on Android:

```csharp
	using Android.App;
	using MyInventory.ViewModels;
	using Intersoft.Crosslight.Android;
	
	namespace MyInventory.Android
	{
	    [Activity(Label = "Edit Item", Icon = "@drawable/icon")]
		public class ItemEditActivity : FormActivity<ItemEditorViewModel>
		{
		}
	}
```

## Windows Phone ##
Consuming the Form Metadata from the view model on Windows Phone:

The page:

```xml
	<Intersoft:PhoneFormPage
	    x:Class="MyInventory.WinPhone.Views.ItemEditPage"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:Intersoft="clr-namespace:Intersoft.Crosslight.WinPhone;assembly=Intersoft.Crosslight.WinPhone"
	    SupportedOrientations="PortraitOrLandscape" Orientation="Portrait">
	
	    <Intersoft:PhoneFormPage.HeaderTemplate>
	        <DataTemplate>
	            <StackPanel Margin="4,17,0,28">
	                <TextBlock Text="CROSSLIGHT APP" Style="{StaticResource PhoneTextNormalStyle}"/>
	            </StackPanel>
	        </DataTemplate>
	    </Intersoft:PhoneFormPage.HeaderTemplate>
	</Intersoft:PhoneFormPage>
```
The code-behind:

```csharp
	using Intersoft.Crosslight;
	using MyInventory.ViewModels;
	
	namespace MyInventory.WinPhone.Views
	{
	    [ViewModelType(typeof(ItemEditorViewModel))]
	    public partial class ItemEditPage
	    {
	        public ItemEditPage()
	        {
	            InitializeComponent();
	        }
	    }
	}
```
----------

# Learn More #

* [Intersoft Crosslight Overview](http://www.intersoftpt.com/Crosslight)
* [Intersoft Crosslight Forum](http://www.intersoftpt.com/Community/Crosslight)
* [Intersoft Crosslight and Xamarin Integration](http://intersoftpt.com/corporate/PressRelease.aspx?page=PressRelease&PressID=0df66ef5-8894-467c-a416-064a2bad7bbb)
* [Intersoft Developer Center](http://developer.intersoftpt.com)
* [Intersoft Solutions Corporate Blog](http://intersoftpt.wordpress.com)
* [Intersoft Support](http://intersoftpt.com/Support/)
* [Intersoft Community](http://intersoftpt.com/Community/)
* [Intersoft Video Tutorials](https://www.youtube.com/user/intersoftpt)

© Intersoft Solutions Corporation. All rights reserved.