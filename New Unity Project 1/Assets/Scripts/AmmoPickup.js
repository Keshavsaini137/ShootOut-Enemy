var AmmoSound : AudioSource;
var ObjectiveLabel : GameObject;
var ObjectiveComplete : GameObject;


function OnTriggerEnter(col : Collider){

ObjectiveLabel = GameObject.Find("Canvas/ObjectivesLabel");
//Debug.Log(ObjectiveLabel);
/*if(GlobalAmmo.LoadedAmmo == 0){
GlobalAmmo.LoadedAmmo += 10;
ObjectiveComplete.SetActive(true);
this.gameObject.SetActive(false);
}
else{*/
if(col.tag == "ThePlayer"){
//Debug.Log(col);
AmmoSound.Play();

GlobalAmmo.CurrentAmmo += 10;
if(ObjectiveLabel.activeSelf){
ObjectiveComplete.SetActive(true);
}

this.gameObject.SetActive(false);

}


}