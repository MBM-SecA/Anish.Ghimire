namespace AllAboutClasses
{
    public class Country
    {
        //Instance Constructors
        //Default Constructor
       public string Name{get;set;}
       public int Population{get;set;}
       public double Area {get;set;}
       public static readonly bool IsOnEarth;//for things that doesn't change in all members and readonly is always static


        public Country()
        {

        }
        //Parameterized constructor
        public Country(string name)
        {
            Name=name;

        }
        public Country(string name,int population,double area)
        {
            Name=name;
            Population=population;
            Area=area;
        }
        //Static Constructor
        static Country()
    {
        IsOnEarth=true;
        


    }
    //Finalizer
    ~Country()
     {

     }
    }
    
    
    public class Demo
    {
        void DoSomething()
        {
            Country country1= new Country();
            Country country2=new Country("Nepal");
        }
    }
}