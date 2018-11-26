namespace MadLibs.Models
{
  public class MadLib
  {
    private string _student;
    private string _station;
    private string _pair;
    private string _verb;
    private string _adjective;
    private string _secondAdjective;
    

    public string GetStudent()
    {
      return _student;
    }

    public void SetStudent(string newStudent)
    {
      _student = newStudent;
    }

    public string GetPair()
    {
      return _pair;
    }

    public void SetPair(string newPair)
    {
      _pair = newPair;
    }
    public string GetStation()
    {
      return _station;
    }

    public void SetStation(string newStation)
    {
      _station = newStation;
    }

     public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }
    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
    public string GetSecondAdjective()
    {
      return _secondAdjective;
    }

    public void SetSecondAdjective(string newSecondAdjective)
    {
      _secondAdjective = newSecondAdjective;
    }
  }
  //Second Story
    public class SecondMadLib
  {
    private string _dogName;
    private string _activity;
  
    private string _adjective;
    private string _food;
    
  
    public string GetDog()
    {
      return _dogName;
    }

    public void SetDog(string newDog)
    {
      _dogName = newDog;
    }
    public string GetActivity()
    {
      return _activity;
    }

    public void SetActivity(string newActivity)
    {
      _activity = newActivity;
    }

     
    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
    public string GetFood()
    {
      return _food;
    }

    public void SetFood(string newFood)
    {
      _food = newFood;
    }
  }
}