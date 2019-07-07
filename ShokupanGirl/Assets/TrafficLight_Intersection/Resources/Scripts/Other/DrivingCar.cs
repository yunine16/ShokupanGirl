using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 車の運転用スクリプト
 */


public class DrivingCar : MonoBehaviour {

	public bool handControl = false;	//運転するかどうか

	//[System.NonSerialized] 
    public float speedNow;	//現在速度 (m/s)
    public float speedCar;
	[System.NonSerialized] public float angleY = 0f;    //車体の方向

    /*
    private float acceralation = 0.1f;  //加速度(1フレームあたり)
    private float turning = 0.5f;		//ハンドルを切る度合い

	[System.NonSerialized] public int gear = 1;         //ギア（1:ドライブ, -1:バック）
	*/

    private Rigidbody rb;
    private Vector3 speedV;

    /*
    //車のライトの設定
    private CarSetting css;
    private GameObject[] frontLight;
    private GameObject[] turnSignal;
    private GameObject[] tailLight;

    //ライトの状態
    private int turnSignalSt = 0;
    private float cTime = 0;
    private float blinkTime = 0.35f;
    private bool frontLightSt = false;
    */


    // Use this for initialization
    void Start () {
		rb = this.GetComponent<Rigidbody> ();	//rigidbodyの取得
		angleY = transform.localEulerAngles.y;	//方向の取得

        speedNow = speedCar;


        /*
        //ライトの設定
        css = this.GetComponent<CarSetting>();
        frontLight = new GameObject[2];
        turnSignal = new GameObject[4];
        tailLight = new GameObject[2];
        for (int i = 0; i < frontLight.Length; i++) {
            frontLight[i] = this.transform.Find("FrontLight (" + (i + 1) + ")").gameObject;
        }
        for (int i = 0; i < tailLight.Length; i++) {
            tailLight[i] = this.transform.Find("TailLight (" + (i + 1) + ")").gameObject;
        }
        for (int i = 0; i < turnSignal.Length; i++) {
            turnSignal[i] = this.transform.Find("TurnSignal (" + (i + 1) + ")").gameObject;
        }
        */
    }

	// Update is called once per frame
	void Update () {
		/*
        if (handControl) {

			//ハンドル
			if (Input.GetKey ("right")) {
				this.transform.RotateAround (this.transform.position, this.transform.up, turning);
			} else if (Input.GetKey ("left")) {
				this.transform.RotateAround (this.transform.position, this.transform.up, -turning);
			} else {
				rb.angularVelocity = Vector3.zero;
			}
			
			//ギアの切り替え
			if (speedNow == 0) {
				if (Input.GetKeyDown (KeyCode.Tab)) {
					if (gear == 1) {
						gear = -1;
					} else {
						gear = 1;
					}
				}
			}

            //フロントライト
            if (Input.GetKey(KeyCode.L)) {
                frontLightSt = true;
            }
            if (Input.GetKey(KeyCode.K)) {
                frontLightSt = false;
            }
            SettingFrontLight(frontLightSt);


            //アクセル・ブレーキ
            if (Input.GetKey ("up")) {
				speedNow += gear * acceralation;
			}
			if (Input.GetKey ("down")) {
				if (gear == 1) {
					if (speedNow > 0) {
						speedNow += -1 * gear * acceralation * 1.5f;
					} else {
						speedNow = 0;
					}
				} else {
					if (speedNow < 0) {
						speedNow += -1 * gear * acceralation * 1.5f;
					} else {
						speedNow = 0;
					}
				}
                //ブレーキランプ
                SettingStopLight(true);

            } else {
                //テールランプ
                SettingTailLight(frontLightSt);
            }

            //ウインカー
            if (Input.GetKey(KeyCode.C)) {
                turnSignalSt = 1;   //右折
            }
            if (Input.GetKey(KeyCode.X)) {
                turnSignalSt = 0;
            }
            if (Input.GetKey(KeyCode.Z)) {
                turnSignalSt = -1;  //左折
            }

            SettingTurnSignal(turnSignalSt, cTime);
            if (cTime >= blinkTime * 2) {
                cTime = 0f;
            } else {
                cTime += Time.deltaTime;
            }


            */

            //実際の移動
            /*
            if (speedNow == 0) {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            } else {
            */
                //速度ベクトル
                speedV = speedNow * this.transform.forward;
                //位置の更新（移動）
                rb.velocity = new Vector3(speedV.x, 0, speedV.z);
        //}
        //}

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "BackBox")
        {
            speedNow = 0;
            rb.velocity = new Vector3(speedV.x, 0, speedV.z);
        }
        else if (col.gameObject.tag == "CarWall"){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "BackBox") {
            speedNow = speedCar;
            rb.velocity = new Vector3(speedV.x, 0, speedV.z);
        }           
    }


    public void StopCar()
    {
        speedNow = 0;
        rb.velocity = new Vector3(speedV.x, 0, speedV.z);
    }

    public void StartCar()
    {
        speedNow = speedCar;
        rb.velocity = new Vector3(speedV.x, 0, speedV.z);
    }
}
