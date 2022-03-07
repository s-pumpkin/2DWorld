using UnityEngine;
using spumpkin;
using spumpkin.Helpers;
public class CameraController : MonoBehaviour
{
    public const float PIXEL_PER_UNIT = 128;

    //縮放
    public float zoomDesired { get; protected set; }
    public float zoomMin { get; protected set; }
    public float zoomMax { get; protected set; }

    public float zoom
    {
        get
        {
            return (
                (Screen.height / (this.zoomDesired * CameraController.PIXEL_PER_UNIT) * .5f)
            );
        }
    }

    //靈敏度
    public float sensitivity { get; protected set; }
    public Vector3 mousePosition { get; protected set; }
    public Vector2Int tileMapMousePosition
    {
        get
        {
            return new Vector2Int((int)this.mousePosition.x, (int)this.mousePosition.y);
        }
    }

    public RectI viewRect;
    private Vector3 _lastMousePosition;
    private Camera _camera;

    //設置相機、最大和最小焦距以及初始所需的焦距
    private void Start()
    {
        this._camera = Camera.main;
        this.zoomMin = .1f;
        this.zoomMax = .6f;
        this.sensitivity = 2f;
        this.zoomDesired = .3f;
    }

    private void Update()
    {
        this.mousePosition = this._camera.ScreenToWorldPoint(Input.mousePosition);
        this.UpdateCamera();
        this._lastMousePosition = this._camera.ScreenToWorldPoint(Input.mousePosition);
    }

    //更新相機位置和相機焦距(縮放)
    private void UpdateCamera()
    {
        if (Input.GetMouseButton(2))
        {
            Vector3 diff = this._lastMousePosition - this.mousePosition;

            if (diff != Vector3.zero)
            {
                this._camera.transform.Translate(diff);
                this.UpdateViewRect();
            }
        }

        this.zoomDesired += this.zoomDesired * Input.GetAxis("Mouse ScrollWheel") * this.sensitivity;
        this.zoomDesired = Mathf.Clamp(this.zoomDesired, this.zoomMin, this.zoomMax);

        if (this.zoom != this._camera.orthographicSize)
        {
            this._camera.orthographicSize = this.zoom;
            this.UpdateViewRect();
        }
    }

    private void UpdateViewRect()
    {
        this.viewRect = new RectI(
            new Vector2Int(
                Mathf.FloorToInt(this._camera.transform.position.x - this._camera.orthographicSize * this._camera.aspect),
                Mathf.FloorToInt(this._camera.transform.position.y - this._camera.orthographicSize)
            ),
            new Vector2Int(
                Mathf.FloorToInt(this._camera.transform.position.x + this._camera.orthographicSize * this._camera.aspect),
                Mathf.FloorToInt(this._camera.transform.position.y + this._camera.orthographicSize)
            )
        );
        Loki.map.UpdateVisibles();
    }
}
