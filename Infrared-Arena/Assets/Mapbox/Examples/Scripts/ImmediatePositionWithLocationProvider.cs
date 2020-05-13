namespace Mapbox.Examples
{
	using Mapbox.Unity.Location;
	using Mapbox.Unity.Map;
	using UnityEngine;

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

		void Start()
		{
			LocationProviderFactory.Instance.mapManager.OnInitialized += () => _isInitialized = true;
		}

		void LateUpdate()
		{
			//if (_isInitialized)
			//{
				var map = LocationProviderFactory.Instance.mapManager;
			
				transform.localPosition = map.GeoToWorldPosition(LocationProvider.CurrentLocation.LatitudeLongitude, true);
				map.UpdateMap(LocationProvider.CurrentLocation.LatitudeLongitude, map.Zoom);
				//transform.localPosition = new Vector3(100f, 100f, 100f);
			//}
		}
	}
}