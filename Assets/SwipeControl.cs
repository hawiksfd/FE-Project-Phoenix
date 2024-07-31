using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwipeControl : MonoBehaviour, IEndDragHandler
{
  [SerializeField] int maxPage;
  int currentPage;
  Vector3 targetPos;
  [SerializeField] Vector3 pageStep;
  [SerializeField] RectTransform levelPagesRect;
  [SerializeField] float tweenTime;
  [SerializeField] LeanTweenType tweenType;
  float dragThreshold;

  [SerializeField] Image[] barImage;
  [SerializeField] Sprite barClosed, barOpen;


  private void Awake(){
    currentPage = 1;
    targetPos = levelPagesRect.localPosition;
    dragThreshold =Screen.width / 15;
    updateBar();
  }

  public void Next(){
    if  (currentPage < maxPage){
      currentPage++;
      targetPos += pageStep;
      movePage();
    }
  }

  public void Previous(){
    if (currentPage > 1)
    currentPage-- ;
    targetPos -= pageStep;
    movePage();
  }

  void movePage(){
    // if(tween != null){
    //   tween.reset();
    //   tween = levelPagesRect.LeanMoveLocal(targetPos,tweenTime).setEase(tweenType);
    // }
    levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
    updateBar();
  }

  public void OnEndDrag(PointerEventData eventData){
    if (Mathf.Abs(eventData.position.x - eventData. pressPosition.x) > dragThreshold){
      if (eventData.position.x > eventData. pressPosition.x) Previous();
      else Next();
    }
    else{
      movePage();
    }
  }
    
  void updateBar(){
    foreach (var item in barImage){
      item.sprite = barClosed;
      barImage[currentPage - 1].sprite = barOpen;
    }
  }


}
