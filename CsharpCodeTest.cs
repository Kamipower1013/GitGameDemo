public partial class Player{

private int ID;
public string playerName;

protected int curLevel;
public Player(int ID ,string Name,int Level){
    this.ID = ID;
    this.playerName = Name;

}





}


public  class BaseSkillUnit{}

public class PlayerOutLineSkill: BaseSkillUnit
{
 public int SkinID;
 public int ActiveLevel;


}



public partial class Player{
    public List<PlayerOutLineSkillPlayerOutLineSkill> outLineSkillList;
    


}


public class CsharpCodeTest : MonoBehaviour {
    
    private List<Player>  playerList;
    void Awake() {
        
    }
    void Start(){

        if(playerList==null){
            playerList=new List<Player>();

        }
    
    }


   void Update(){


   }
   void LateUpdate() {
    
   }

}