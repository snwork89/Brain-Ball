using UnityEngine;

public class LineDrawer : MonoBehaviour
{

	public GameObject linePrefab;
	public LayerMask cantDrawOverLayer;
	int cantDrawOverLayerIndex;

	[Space(30f)]
	public Gradient lineColor;
	public float linePointsMinDistance;
	public float lineWidth;

	Line currentLine;

	Camera cam;


	void Start()
	{
		cam = Camera.main;
		cantDrawOverLayerIndex = LayerMask.NameToLayer("CantDrawOver");
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
			BeginDraw();

		if (currentLine != null)
			Draw();

		if (Input.GetMouseButtonUp(0))
			EndDraw();
	}

	
	void BeginDraw()
	{
		currentLine = Instantiate(linePrefab, this.transform).GetComponent<Line>();

		
		currentLine.UsePhysics(false);
		currentLine.SetLineColor(lineColor);
		currentLine.SetPointsMinDistance(linePointsMinDistance);
		currentLine.SetLineWidth(lineWidth);

	}
	// Draw ----------------------------------------------------
	void Draw()
	{
		Vector2 mousePosition =new Vector2(cam.ScreenToWorldPoint(Input.mousePosition).x+4.0f, cam.ScreenToWorldPoint(Input.mousePosition).y) ;
		Debug.Log(mousePosition);
	
		//RaycastHit2D hit = Physics2D.CircleCast(mousePosition, lineWidth / 3f, Vector2.zero, 1f, cantDrawOverLayer);

		//if (hit)
		//	EndDraw();
		//else
			currentLine.AddPoint(mousePosition);
	}
	// End Draw ------------------------------------------------
	void EndDraw()
	{
		if (currentLine != null)
		{
			if (currentLine.pointsCount < 2)
			{
				
				Destroy(currentLine.gameObject);
			}
			else
			{
				
				currentLine.gameObject.layer = cantDrawOverLayerIndex;

			
				currentLine.UsePhysics(true);

				currentLine = null;
			}
		}
	}
}