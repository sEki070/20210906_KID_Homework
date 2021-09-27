using UnityEngine;
/// <summary>
/// NPC
/// 定義NPC方法
/// </summary>
public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="converstation
    private void conversation(string conversation)
    {

    }
    /// <summary>
    /// 開啟商店 
    /// </summary>
    public bool Openshop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="itemprize"></param>
    public int Shopping(int itemprize = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="indexMission"></param>
    public void Getmission(int incexMission)
    {

    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="propMission"></param>
    private int MissionUpdate(int propMission)
    {
        return 0;
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="indexMMission
    private bool MissionComplete(int indexMission)
    {
        return false;
    }
    #region 練習
    private void move(float movespeed)
    {

    }
    private float movemutton()
    {
        return 0f;
    }
    private bool groundcheck()
    {
        return false;
    }
    private void jump(){ }
    private void AnimateUpdate() { }
    #endregion
}
