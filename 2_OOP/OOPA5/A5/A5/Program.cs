using A5.Question1;
using A5.Question2;
using A5.Question3;

namespace A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Circle circleObj = new Circle(1);
            //circleObj.DisplayShapeInfo();

            //Rectangle rectObj = new Rectangle(1,2);
            //rectObj.DisplayShapeInfo();
            #endregion

            #region Q2
            //IAuthenticationService auth = new BasicAuthenticationService("Ahmed",123,IAuthenticationService.Roles.VP);
            //bool isAuthenticated = auth.AuthenticateUser("Ahmed",144);
            //Console.WriteLine(isAuthenticated);

            //bool isAuthrized = auth.AuthorizeUser("Ahmed", IAuthenticationService.Roles.VP);
            //Console.WriteLine(isAuthrized);
            #endregion

            #region Q3
            INotificationService email = new EmailNotificationService();
            INotificationService sms = new SmsNotificationService();
            INotificationService push = new PushNotificationService();

            email.SendNotification("Sarah", "Dear Sarah, I hope this emailfinds you well...");
            sms.SendNotification("Sarah", "Hey Sarah, How are you?");
            push.SendNotification("Sarah", "New Notification was received");
            #endregion
        }
    }
}
