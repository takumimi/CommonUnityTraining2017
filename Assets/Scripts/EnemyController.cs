using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour 
{
	
	// UIController を参照する
	public UIController UIController;

	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");  //Horizontalは水平方向
		float z = Input.GetAxis("Vertical");    //Verticalは垂直方向

		//Playerが持つRigidbodyを取得
		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		//Rigidbody のx軸（横）z軸（奥）に力を加える
		rigidbody.AddForce(x * 3, 0, z * 3);}
	
    //Trigger との接触時に呼ばれる　Callback
	private void OnCollisionEnter (Collision col)
	{
		//接触対象はPlayer タグかどうか
		if (col.CompareTag ("Player"))
		{
			//Rigidbody を停止させる
			col.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			//ゲームオーバーを表示する
			UIController.ShowGameOverLabel();
			UIController.ShowRetryButton();
		}
	}
}
