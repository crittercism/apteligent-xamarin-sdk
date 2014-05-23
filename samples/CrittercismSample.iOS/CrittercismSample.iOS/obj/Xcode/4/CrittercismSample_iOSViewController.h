// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface CrittercismSample_iOSViewController : UIViewController {
	UIButton *_ButtonAttachUserMetadata;
	UIButton *_buttonCLRException;
	UIButton *_buttonCrashCLR;
	UIButton *_buttonCrashNative;
	UIButton *_buttonLeaveBreadcrumb;
	UIButton *_buttonMisc1;
	UIButton *_buttonMisc2;
	UIButton *_buttonMisc3;
	UIButton *_buttonNativeException;
	UIImageView *_imageCrittercism;
}

@property (nonatomic, retain) IBOutlet UIButton *ButtonAttachUserMetadata;

@property (nonatomic, retain) IBOutlet UIButton *buttonCLRException;

@property (nonatomic, retain) IBOutlet UIButton *buttonCrashCLR;

@property (nonatomic, retain) IBOutlet UIButton *buttonCrashNative;

@property (nonatomic, retain) IBOutlet UIButton *buttonLeaveBreadcrumb;

@property (nonatomic, retain) IBOutlet UIButton *buttonMisc1;

@property (nonatomic, retain) IBOutlet UIButton *buttonMisc2;

@property (nonatomic, retain) IBOutlet UIButton *buttonMisc3;

@property (nonatomic, retain) IBOutlet UIButton *buttonNativeException;

@property (nonatomic, retain) IBOutlet UIImageView *imageCrittercism;

- (IBAction)actionAttachUserMetadata:(id)sender;

- (IBAction)actionBreadcrumb:(id)sender;

- (IBAction)actionCLRException:(id)sender;

- (IBAction)actionCrashCLR:(id)sender;

- (IBAction)actionCrashNative:(id)sender;

- (IBAction)actionNativeException:(id)sender;

@end
