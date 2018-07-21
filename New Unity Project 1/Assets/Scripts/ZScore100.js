var ObjectiveComplete : GameObject;

function DeductPoints (DamageAmount : int){
    GlobalScore.CurrentScore += 100;//GlobalScore.CurrentScore = GlobalScore.CurrentScore + 100;
    ObjectiveComplete.SetActive(true);
}
