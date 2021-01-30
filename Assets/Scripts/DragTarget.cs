using UnityEngine;

public class DragTarget : MonoBehaviour
{
	public LayerMask m_DragLayers;
	[Range (0.0f, 100.0f)]
	public float m_Damping = 1.0f;
	[Range (0.0f, 100.0f)]
	public float m_Frequency = 5.0f;
	public bool m_DrawDragLine = true;
	public Color m_Color = Color.cyan;
	private TargetJoint2D m_TargetJoint;
	public SpringJoint2D m_TargetSpring;
	public GameObject Ship;
	public GameObject Part;
	public Player player;

	void Update ()
	{
		var worldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		if (Input.GetMouseButtonDown (0))
		{
			var collider = Physics2D.OverlapPoint (worldPos, m_DragLayers);
			if (!collider)
				return;

			var body = collider.attachedRigidbody;
			if (!body)
				return;

			Part.GetComponent<PolygonCollider2D>().enabled = false;
			m_TargetJoint = body.gameObject.AddComponent<TargetJoint2D> ();
			m_TargetJoint.dampingRatio = m_Damping;
			m_TargetJoint.frequency = m_Frequency;

			player.velocity.constraints = RigidbodyConstraints2D.None;
			m_TargetSpring = body.gameObject.GetComponent<SpringJoint2D> ();
			m_TargetJoint.anchor = m_TargetJoint.transform.InverseTransformPoint (worldPos);		
		}
		else if (Input.GetMouseButtonUp (0))
		{
			Part.GetComponent<PolygonCollider2D>().enabled = true;
			Destroy (m_TargetJoint);
			m_TargetJoint = null;
			return;
		}

		if (m_TargetJoint)
		{
			m_TargetJoint.target = worldPos;
			if (m_DrawDragLine)
				Debug.DrawLine (m_TargetJoint.transform.TransformPoint (m_TargetJoint.anchor), worldPos, m_Color);
		}
	}
}
