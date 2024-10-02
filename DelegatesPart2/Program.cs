using ClubMembershipApplication.Views;

namespace ClubMembershipApplication;
public class Programe
{
    public static void Main(string[] args)
    {
        IView mainView = Factory.GetMainViewObject();
        mainView.RunView();

        Console.ReadKey();
    }
}