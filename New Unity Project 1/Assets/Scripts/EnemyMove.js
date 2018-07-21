var ThePlayer : GameObject;
var TheEnemy : GameObject;
var EnemySpeed : float;
var MoveTrigger : int;
var TheDistance : float = PlayerCasting.DistanceFromTarget;

MoveTargger = TheDistance;
function Update(){
if(MoveTrigger == 1){
    EnemySpeed = 0.05;
    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
    }
}