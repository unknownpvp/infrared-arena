namespace Mapbox.Examples
{
	using Mapbox.Unity.Location;
	using Mapbox.Unity.Map;
	using UnityEngine;
	using System.IO;
	using System.Text;

	public class ImmediatePositionWithLocationProvider : MonoBehaviour
	{

		bool _isInitialized;

		ILocationProvider _locationProvider;
		ILocationProvider LocationProvider
		{
			get
			{
				if (_locationProvider == null)
				{
					_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider;
				}

				return _locationProvider;
			}
		}

		Vector3 _targetPosition;

		string path;

		void Start()
		{
			LocationProviderFactory.Instance.mapManager.OnInitialized += () => _isInitialized = true;

			path = Application.dataPath + "/LocationLog.txt";
			Debug.Log(path);

			if(!File.Exists(path))
			{
				File.WriteAllText(path, "Begin log");
			}
		}

		void LateUpdate()
		{
			//if (_isInitialized)
			//{
				var map = LocationProviderFactory.Instance.mapManager;
			
				transform.localPosition = map.GeoToWorldPosition(LocationProvider.CurrentLocation.LatitudeLongitude, true);
				map.UpdateMap(LocationProvider.CurrentLocation.LatitudeLongitude, map.Zoom);
				string locationString = LocationProvider.CurrentLocation.LatitudeLongitude.x + "," + LocationProvider.CurrentLocation.LatitudeLongitude.y;
				File.WriteAllText(path, locationString);
				//transform.localPosition = new Vector3(100f, 100f, 100f);
			//}
		}
	}
}