var DamageAmount : int;
var TargetDistance : float;
var AllowedRange : float = 60;
var Hit : RaycastHit;
var TheBullet : GameObject;
var TheBlood : GameObject;
var TheBloodGreen : GameObject;

function Start(){
DamageAmount = 5;
}


function Update () {
if(GlobalAmmo.LoadedAmmo >= 1 ){
	if(Input.GetButtonDown("Fire1")) {

		var Shot : RaycastHit;
			if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), Shot)) {
				TargetDistance = Shot.distance;
					if (TargetDistance < AllowedRange) {


                        //Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), Hit)){

                            if(Hit.transform.tag =="Zombie"){
                                Instantiate(TheBlood, Hit.point, Quaternion.FromToRotation(Vector3.up, Hit.normal));
                            }

                            if(Hit.collider.tag =="ZombieHead"){
                            DamageAmount = 10;
                                Instantiate(TheBlood, Hit.point, Quaternion.FromToRotation(Vector3.up, Hit.normal));
                            }


                            if(Hit.transform.tag =="Spider"){
                                Instantiate(TheBloodGreen, Hit.point, Quaternion.FromToRotation(Vector3.up, Hit.normal));
                            }

                            if(Hit.transform.tag == "Untagged"){
                        Instantiate(TheBullet, Hit.point, Quaternion.FromToRotation(Vector3.up, Hit.normal));
                        }
                     }
                     Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                     DamageAmount = 5;
				}
			}
		}
	}

}
