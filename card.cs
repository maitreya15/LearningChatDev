activity.TextFormat = "markdown";
                //activity.Text = "Please greet me!!";
                Activity reply = activity.CreateReply(activity.Text);
                // card code here
                reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                reply.Attachments = new List<Attachment>();

                CardAction _Link2 = new CardAction("OpenUrl", "Goooogle", "null", "https://gmail.com");
                CardAction _Link = new CardAction("openUrl","Google",null,"https://Google.com");
                CardImage _GoogleLogo = new CardImage("https://www.google.co.in/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjNhOmWmezbAhWNfSsKHeRgDfsQjRx6BAgBEAU&url=http%3A%2F%2Fcode.google.com%2F&psig=AOvVaw2ZUzvGDsRE-xeeTRfFcM7E&ust=1529926147635999");

                HeroCard googlecard = new HeroCard();

                googlecard.Buttons = new List<CardAction>();
                googlecard.Images = new List<CardImage>();
                
                googlecard.Buttons.Add(_Link);
                googlecard.Images.Add(_GoogleLogo);
                googlecard.Title= "Google";

                googlecard.Buttons.Add(_Link2);
                reply.Attachments.Add(googlecard.ToAttachment());
