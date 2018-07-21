var EnemyHealth : int = 10;
var TheZombie : GameObject;
public var Score : GameObject;
static var scoreValue = 1;
var numberOfZombieDie = 0;
var enemyDie = false;


var ObjectiveLabel : GameObject;
var ObjectiveComplete : GameObject;


function DeductPoints (DamageAmount : int){
EnemyHealth -= DamageAmount;
}

function Update (){

if (EnemyHealth <= 0){
ObjectiveComplete = GameObject.Find("Canvas/ObjectivesLabel/Objective03/BlueTick");
ObjectiveLabel = GameObject.Find("Canvas/ObjectivesLabel");

this.GetComponent("ZombieFollow").enabled=false;

if(ObjectiveLabel.activeSelf){
ObjectiveComplete.SetActive(true);

}


TheZombie.GetComponent.<Animation>().Play("Dying");
EndZombie();
}

}


function EndZombie(){
yield WaitForSeconds(3);
numberOfZombieDie = 1;

//ObjectiveLabel.SetActive(false);

GlobalScore.score = GlobalScore.score + scoreValue;
//Debug.Log(numberOfZombieDie);
Destroy(gameObject);

}

