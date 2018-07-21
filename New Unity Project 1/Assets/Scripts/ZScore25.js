var ObjectiveComplete : GameObject;


function DeductPoints (DamageAmount : int){
    GlobalScore.CurrentScore += 25;
    ObjectiveComplete.SetActive(true);
}
