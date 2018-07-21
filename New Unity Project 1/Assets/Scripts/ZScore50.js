var ObjectiveComplete : GameObject;

function DeductPoints (DamageAmount : int){
    GlobalScore.CurrentScore += 50;
    ObjectiveComplete.SetActive(true);
}
