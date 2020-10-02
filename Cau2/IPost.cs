namespace Cau2
{
    public interface IPost
    {
        int Id {get;set;}
        string Title {get;set;}
        string Content {get;set;}
        string Author {get;set;}
        float AverageRate {get;}
         void Display();
         void CalculatoRate();
    }
}