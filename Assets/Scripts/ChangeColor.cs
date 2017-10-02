using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ChangeColor : MonoBehaviour {
	[Header("Game Controller")]
	public GameObject gamecontroller;
	[Space(20)]
	[Header("Sprite Renderer et Animator")]
	public SpriteRenderer rend;
	public Animator anim;
	[Space(20)]
	[Header("Horizontal ?")]
	public bool horizontal;
	[Space(20)]
	[Header("Vertical ?")]
	public bool vertical;
	[Space(20)]
	[Header("Force de l'effet horizontal")]
	[Range(-10,10)]
	public float Forceh;
	[Space(20)]
	[Header("Force de l'effet vertical")]
	[Range(-10,10)]
	public float Forcev;
	[Space(20)]
	[Header("Direction de l'effet horizontal")]
	public float Angleh;
	[Space(30)]
	[Header("Direction de l'effet vertical")]
	public float Anglev;
	[Space(30)]
	[Header("Zone d'effet rouge horizontale")]
	public GameObject redzoneh;
	public Vector2 RedzonehOffset1;
	public Vector2 RedzonehSize1;
	public Vector2 RedzonehOffset2;
	public Vector2 RedzonehSize2;
	public Vector2 RedzonehOffset3;
	public Vector2 RedzonehSize3;
	[Space(30)]
	[Header("Zone d'effet bleue horizontale")]
	public GameObject bluezoneh;
	public Vector2 BluezonehOffset1;
	public Vector2 BluezonehSize1;
	public Vector2 BluezonehOffset2;
	public Vector2 BluezonehSize2;
	public Vector2 BluezonehOffset3;
	public Vector2 BluezonehSize3;
	[Space(30)]
	[Header("Zone d'effet rouge verticale")]
	public GameObject redzonev;
	public Vector2 RedzonevOffset1;
	public Vector2 RedzonevSize1;
	public Vector2 RedzonevOffset2;
	public Vector2 RedzonevSize2;
	public Vector2 RedzonevOffset3;
	public Vector2 RedzonevSize3;
	[Space(30)]
	[Header("Zone d'effet bleue verticale")]
	public GameObject bluezonev;
	public Vector2 BluezonevOffset1;
	public Vector2 BluezonevSize1;
	public Vector2 BluezonevOffset2;
	public Vector2 BluezonevSize2;
	public Vector2 BluezonevOffset3;
	public Vector2 BluezonevSize3;
	[Space(30)]
	private MouseColor mc;
	[Header("Couleurs Peinture Rouge")]
	public List<Color> red;
	[Space(10)]
	[Header("Couleurs Peinture Bleue")]
	public List<Color> blue;
	[Space(10)]
	[Header("Couleurs Peinture Blanche")]
	public Color white;
	[Space(10)]
	private int r;
	private int b;

	void Start()
	{
		mc = gamecontroller.GetComponent<MouseColor>();
		r = 0;
		b = 0;

	}

	void OnTouchDown()
	{
		if(mc.red == true){

			if(rend.color == red[2]){
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == red[1]){
				r++;
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == red[0]){
				r++;
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == white){
				rend.color = red[r];
				anim.SetBool("White_To_Red", true);
			}

		}

		if(mc.blue == true){
			if(rend.color == blue[2]){
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == blue[1]){
				b++;
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == blue[0]){
				b++;
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == white){
				rend.color = blue[b];
				anim.SetBool("White_To_Blue", true);
			}
		}
		
		if(mc.white == true)
		{
			r = 0;
			b = 0;
			anim.SetInteger("Red", r);
			anim.SetBool("White_To_Red", false);
			anim.SetBool("White_To_Blue", false);
			rend.color = white;
		}
	}


	void OnMouseDown()
	{
		if(mc.red == true){

			if(rend.color == red[2]){
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == red[1]){
				r++;
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == red[0]){
				r++;
				rend.color = red[r];
				anim.SetInteger("Red", r);
			}
			if(rend.color == white){
				rend.color = red[r];
				anim.SetBool("White_To_Red", true);
			}

		}

		if(mc.blue == true){
			if(rend.color == blue[2]){
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == blue[1]){
				b++;
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == blue[0]){
				b++;
				rend.color = blue[b];
				anim.SetInteger("Blue", b);
			}
			if(rend.color == white){
				rend.color = blue[b];
				anim.SetBool("White_To_Blue", true);
			}
		}
		
		if(mc.white == true)
		{
			r = 0;
			b = 0;
			anim.SetInteger("Red", r);
			anim.SetBool("White_To_Red", false);
			anim.SetBool("White_To_Blue", false);
			rend.color = white;
		}
	}

	void Update()
	{
		r = Mathf.Clamp(r,0,2);
		b = Mathf.Clamp(b,0,2);

		if(horizontal == true)
		{
			if(rend.color == red[0]){
			redzoneh.SetActive(true);
			bluezoneh.SetActive(false);
			redzoneh.GetComponent<BoxCollider2D>().offset = RedzonehOffset1;
			redzoneh.GetComponent<BoxCollider2D>().size = RedzonehSize1;
			redzoneh.GetComponent<AreaEffector2D>().forceMagnitude = Forceh;
			redzoneh.GetComponent<AreaEffector2D>().forceAngle = Angleh;
			}
		if(rend.color == red[1]){
			redzoneh.SetActive(true);
			bluezoneh.SetActive(false);
			redzoneh.GetComponent<BoxCollider2D>().offset = new Vector2 (RedzonehOffset1.x*2, RedzonehOffset1.y);
			redzoneh.GetComponent<BoxCollider2D>().size = new Vector2 (RedzonehSize1.x*2, RedzonehSize1.y);
			redzoneh.GetComponent<AreaEffector2D>().forceMagnitude = Forceh*2;
			redzoneh.GetComponent<AreaEffector2D>().forceAngle = Angleh;
			}
		if(rend.color == red[2]){
			redzoneh.SetActive(true);
			bluezoneh.SetActive(false);
			redzoneh.GetComponent<BoxCollider2D>().offset = new Vector2 (RedzonehOffset1.x*4, RedzonehOffset1.y);
			redzoneh.GetComponent<BoxCollider2D>().size = new Vector2 (RedzonehSize1.x*4, RedzonehSize1.y);
			redzoneh.GetComponent<AreaEffector2D>().forceMagnitude = Forceh*4;
			redzoneh.GetComponent<AreaEffector2D>().forceAngle = Angleh;
			}

		if(rend.color == blue[0]){
			redzoneh.SetActive(false);
			bluezoneh.SetActive(true);
			bluezoneh.GetComponent<BoxCollider2D>().offset = BluezonehOffset1;
			bluezoneh.GetComponent<BoxCollider2D>().size = BluezonehSize1;
			bluezoneh.GetComponent<AreaEffector2D>().forceMagnitude = -Forceh;
			bluezoneh.GetComponent<AreaEffector2D>().forceAngle = -Angleh;
			}
		if(rend.color == blue[1]){
			redzoneh.SetActive(false);
			bluezoneh.SetActive(true);
			bluezoneh.GetComponent<BoxCollider2D>().offset = new Vector2 (BluezonehOffset1.x*2, BluezonehOffset1.y);
			bluezoneh.GetComponent<BoxCollider2D>().size = new Vector2 (BluezonehSize1.x*2, BluezonehSize1.y);
			bluezoneh.GetComponent<AreaEffector2D>().forceMagnitude = -Forceh*2;
			bluezoneh.GetComponent<AreaEffector2D>().forceAngle = -Angleh;
			}
		if(rend.color == blue[2]){
			redzoneh.SetActive(false);
			bluezoneh.SetActive(true);
			bluezoneh.GetComponent<BoxCollider2D>().offset = new Vector2 (BluezonehOffset1.x*4, BluezonehOffset1.y);
			bluezoneh.GetComponent<BoxCollider2D>().size = new Vector2 (BluezonehSize1.x*4, BluezonehSize1.y);
			bluezoneh.GetComponent<AreaEffector2D>().forceMagnitude = -Forceh*4;
			bluezoneh.GetComponent<AreaEffector2D>().forceAngle = -Angleh;
			}	
		}

		if(vertical == true)
		{
			if(rend.color == red[0]){
			redzonev.SetActive(true);
			bluezonev.SetActive(false);
			redzonev.GetComponent<BoxCollider2D>().offset = RedzonevOffset1;
			redzonev.GetComponent<BoxCollider2D>().size = RedzonevSize1;
			redzonev.GetComponent<AreaEffector2D>().forceMagnitude = Forcev;
			redzonev.GetComponent<AreaEffector2D>().forceAngle = Anglev;
			}
		if(rend.color == red[1]){
			redzonev.SetActive(true);
			bluezonev.SetActive(false);
			redzonev.GetComponent<BoxCollider2D>().offset = new Vector2 (RedzonevOffset1.x, RedzonevOffset1.y*2);
			redzonev.GetComponent<BoxCollider2D>().size = new Vector2 (RedzonevSize1.x, RedzonevSize1.y*2);
			redzonev.GetComponent<AreaEffector2D>().forceMagnitude = Forcev*2;
			redzonev.GetComponent<AreaEffector2D>().forceAngle = Anglev;
			}
		if(rend.color == red[2]){
			redzonev.SetActive(true);
			bluezonev.SetActive(false);
			redzonev.GetComponent<BoxCollider2D>().offset = new Vector2 (RedzonevOffset1.x, RedzonevOffset1.y*2);
			redzonev.GetComponent<BoxCollider2D>().size = new Vector2 (RedzonevSize1.x, RedzonevSize1.y*2);
			redzonev.GetComponent<AreaEffector2D>().forceMagnitude = Forcev*4;
			redzonev.GetComponent<AreaEffector2D>().forceAngle = Anglev;
			}

		if(rend.color == blue[0]){
			redzonev.SetActive(false);
			bluezonev.SetActive(true);
			bluezonev.GetComponent<BoxCollider2D>().offset = BluezonevOffset1;
			bluezonev.GetComponent<BoxCollider2D>().size = BluezonevSize1;
			bluezonev.GetComponent<AreaEffector2D>().forceMagnitude = -Forcev;
			bluezonev.GetComponent<AreaEffector2D>().forceAngle = -Anglev;
			}
		if(rend.color == blue[1]){
			redzonev.SetActive(false);
			bluezonev.SetActive(true);
			bluezonev.GetComponent<BoxCollider2D>().offset = new Vector2 (BluezonevOffset1.x, BluezonevOffset1.y)*2;
			bluezonev.GetComponent<BoxCollider2D>().size = new Vector2 (BluezonevSize1.x, BluezonevSize1.y*2);
			bluezonev.GetComponent<AreaEffector2D>().forceMagnitude = -Forcev*2;
			bluezonev.GetComponent<AreaEffector2D>().forceAngle = -Anglev;
			}
		if(rend.color == blue[2]){
			redzonev.SetActive(false);
			bluezonev.SetActive(true);
			bluezonev.GetComponent<BoxCollider2D>().offset = new Vector2 (BluezonevOffset1.x, BluezonevOffset1.y*2);
			bluezonev.GetComponent<BoxCollider2D>().size = new Vector2 (BluezonevSize1.x, BluezonevSize1.y*2);
			bluezonev.GetComponent<AreaEffector2D>().forceMagnitude = -Forcev*4;
			bluezonev.GetComponent<AreaEffector2D>().forceAngle = -Anglev;
			}	
		}
		

		if(rend.color == white)
		{
			redzoneh.SetActive(false);
			bluezoneh.SetActive(false);
			redzonev.SetActive(false);
			bluezonev.SetActive(false);
		}
	}

 
 }
