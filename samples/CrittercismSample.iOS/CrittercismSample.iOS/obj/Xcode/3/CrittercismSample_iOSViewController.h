// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface CrittercismSample_iOSViewController : UIViewController {
}
@property (retain, nonatomic) IBOutlet UIButton *ButtonAttachUserMetadata;
@property (retain, nonatomic) IBOutlet UIButton *buttonCrashNative;
@property (retain, nonatomic) IBOutlet UIButton *buttonNativeException;
@property (retain, nonatomic) IBOutlet UIButton *buttonCrashCLR;
@property (retain, nonatomic) IBOutlet UIButton *buttonCLRException;
@property (retain, nonatomic) IBOutlet UIButton *buttonLeaveBreadcrumb;
@property (retain, nonatomic) IBOutlet UIImageView *imageCrittercism;
@property (retain, nonatomic) IBOutlet UIButton *buttonMisc1;
@property (retain, nonatomic) IBOutlet UIButton *buttonMisc2;
@property (retain, nonatomic) IBOutlet UIButton *buttonMisc3;

- (IBAction)actionAttachUserMetadata:(id)sender;

- (IBAction)actionBreadcrumb:(id)sender;

- (IBAction)actionCLRException:(id)sender;

- (IBAction)actionCrashCLR:(id)sender;

- (IBAction)actionCrashNative:(id)sender;

- (IBAction)actionNativeException:(id)sender;

@end
