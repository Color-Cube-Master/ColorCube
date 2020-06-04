using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eightball;
    public GameObject Droid;
    public GameObject Baseball;
    public GameObject Basketball;
    public GameObject Beachball;
    public GameObject Buckyball;
     public GameObject CLBall;
    public GameObject chaosball;
    public GameObject Cricketball;
    public GameObject discoball;
     public GameObject dustyball;
     public GameObject eye;
     public GameObject golfball;
     public GameObject loveEmo;
     public GameObject earth;
     public GameObject ornament;
     public GameObject pokemonball;
     public GameObject robot;
     public GameObject soccerball;
     public GameObject spikeball;
    public GameObject tennisball;
    public  GameObject FirstBall;
     public GameObject tooblueball;
      public GameObject YellowBall;
     
    void Awake(){
        

    }
    void Start()
    {
      //For instant start
    if (Model.Name=="1-Yellow ball") 
      LevelSpawner.Playername= YellowBall;
       else if (Model.Name=="2-DustyBall") 
      LevelSpawner.Playername= dustyball;
       else if (Model.Name=="3-BeachBall") 
      LevelSpawner.Playername= Beachball;
       else if (Model.Name=="4-BasketBall") 
      LevelSpawner.Playername=  Basketball;
       else if (Model.Name=="5-Golf_ball") 
      LevelSpawner.Playername= golfball;
       else if (Model.Name=="6-TennisBall") 
      LevelSpawner.Playername= tennisball;
       else if (Model.Name=="7-Ornament") 
      LevelSpawner.Playername= ornament;
       else if (Model.Name=="8-Baseball") 
      LevelSpawner.Playername= Baseball;
       else if (Model.Name=="9-Soccer_ball") 
      LevelSpawner.Playername= soccerball;
       else if (Model.Name=="10-TooBlueBall") 
      LevelSpawner.Playername= tooblueball;
       else if (Model.Name=="11-ChaosBall") 
      LevelSpawner.Playername= chaosball;
       else if (Model.Name=="12-CricketBall") 
      LevelSpawner.Playername= Cricketball;
      else if (Model.Name=="13-LoveEmoji") 
      LevelSpawner.Playername= loveEmo;
       else if (Model.Name=="14-DiscoBall") 
      LevelSpawner.Playername= discoball;
      else if (Model.Name=="15-Ball droid") 
      LevelSpawner.Playername= Droid;
       else if (Model.Name=="16-8Ball") 
      LevelSpawner.Playername= eightball;
       else if (Model.Name=="17-Eyeball") 
      LevelSpawner.Playername= eye; // Eye is bugged
       else if (Model.Name=="18-AtomesBall") 
      LevelSpawner.Playername= Buckyball;
       else if (Model.Name=="19-PokemonBall") 
      LevelSpawner.Playername=pokemonball;
      else  if (Model.Name=="20-Lowpoly_earth") 
      LevelSpawner.Playername= earth;
       else if (Model.Name=="21-SpikedBall") 
      LevelSpawner.Playername= spikeball;
       else if (Model.Name=="22-Champions_league ball") 
      LevelSpawner.Playername= CLBall;
       else if (Model.Name=="23-Robot sphere") 
      LevelSpawner.Playername= robot;
      else
      LevelSpawner.Playername= FirstBall; 
        }

    // Update is called once per frame
    void Update()
    {
        if (Model.Name=="1-Yellow ball") 
      LevelSpawner.Playername= YellowBall;
       else if (Model.Name=="2-DustyBall") 
      LevelSpawner.Playername= dustyball;
       else if (Model.Name=="3-BeachBall") 
      LevelSpawner.Playername= Beachball;
       else if (Model.Name=="4-BasketBall") 
      LevelSpawner.Playername=  Basketball;
       else if (Model.Name=="5-Golf_ball") 
      LevelSpawner.Playername= golfball;
       else if (Model.Name=="6-TennisBall") 
      LevelSpawner.Playername= tennisball;
       else if (Model.Name=="7-Ornament") 
      LevelSpawner.Playername= ornament;
       else if (Model.Name=="8-Baseball") 
      LevelSpawner.Playername= Baseball;
       else if (Model.Name=="9-Soccer_ball") 
      LevelSpawner.Playername= soccerball;
       else if (Model.Name=="10-TooBlueBall") 
      LevelSpawner.Playername= tooblueball;
       else if (Model.Name=="11-ChaosBall") 
      LevelSpawner.Playername= chaosball;
       else if (Model.Name=="12-CricketBall") 
      LevelSpawner.Playername= Cricketball;
      else if (Model.Name=="13-LoveEmoji") 
      LevelSpawner.Playername= loveEmo;
       else if (Model.Name=="14-DiscoBall") 
      LevelSpawner.Playername= discoball;
      else if (Model.Name=="15-Ball droid") 
      LevelSpawner.Playername= Droid;
       else if (Model.Name=="16-8Ball") 
      LevelSpawner.Playername= eightball;
       else if (Model.Name=="17-Eyeball") 
      LevelSpawner.Playername= eye; // Eye is bugged
       else if (Model.Name=="18-AtomesBall") 
      LevelSpawner.Playername= Buckyball;
       else if (Model.Name=="19-PokemonBall") 
      LevelSpawner.Playername=pokemonball;
      else  if (Model.Name=="20-Lowpoly_earth") 
      LevelSpawner.Playername= earth;
       else if (Model.Name=="21-SpikedBall") 
      LevelSpawner.Playername= spikeball;
       else if (Model.Name=="22-Champions_league ball") 
      LevelSpawner.Playername= CLBall;
       else if (Model.Name=="23-Robot sphere") 
      LevelSpawner.Playername= robot;
      else
      LevelSpawner.Playername= FirstBall; 
      
    }
}
