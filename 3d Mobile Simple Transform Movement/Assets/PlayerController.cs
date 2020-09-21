using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void RightMove(){
        this.gameObject.transform.position = new Vector3(gameObject.transform.position.x,0,this.gameObject.transform.position.z-1);
        print(this.gameObject.transform.position);
    }
    
    public void LeftMove(){
        this.gameObject.transform.position = new Vector3(gameObject.transform.position.x,0,this.gameObject.transform.position.z+1);
        print(this.gameObject.transform.position);
        
    }
    
    public void UpMove(){
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x+1,0,this.gameObject.transform.position.z);
        print(this.gameObject.transform.position);
    }

    public void BackMove(){
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x-1,0,this.gameObject.transform.position.z);
        print(this.gameObject.transform.position);
    }
}
