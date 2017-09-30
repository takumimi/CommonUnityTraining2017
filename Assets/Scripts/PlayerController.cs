using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");  //Horizontalは水平方向
		float z = Input.GetAxis("Vertical");    //Verticalは垂直方向
	
		//Playerが持つRigidbodyを取得
		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		//Rigidbody のx軸（横）z軸（奥）に力を加える
		rigidbody.AddForce(x * 5, 0, z * 5);
	}
}