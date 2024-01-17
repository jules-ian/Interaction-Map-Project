// Map.js
import React, { useEffect, useRef, useState } from "react";
import mapboxgl from "mapbox-gl";
import "mapbox-gl/dist/mapbox-gl.css";
import MapMarker from "./MapMarker";
import useWindowDimensions from "../utils/windowDimension";

mapboxgl.accessToken =
  "pk.eyJ1Ijoic29uZHJlbHV4IiwiYSI6ImNsbnZ3aXRneDAzcDcydG82NGE2dG4xYnQifQ._TpEa0XTz2SpM5Zv9xju_w";

const Map = ({ setMapBounds, results }) => {
  const mapContainerRef = useRef(null);
  const { height, width } = useWindowDimensions();
  const [mapCenter, setMapCenter] = useState([1.4442, 43.6047]);
  const [mapZoom, setMapZoom] = useState(7);
  const [prevMapCenter, setPrevMapCenter] = useState([1.4442, 43.6047]);
  const [prevMapZoom, setPrevMapZoom] = useState(7);
  const [maxZoom, setMaxZoom] = useState(20);

  useEffect(() => {
    const map = new mapboxgl.Map({
      container: mapContainerRef.current,
      style: "mapbox://styles/mapbox/streets-v11",
      center: mapCenter,
      zoom: mapZoom,
    });

    const nav = new mapboxgl.NavigationControl({
      showZoom: true,
      showCompass: false,
    });

    map.addControl(nav, "bottom-right");

    // Set initial map bounds
    setMapBounds(map.getBounds());

    // Listen for map move events and update bounds
    map.on("move", () => {
      const currentMapCenter = map.getCenter().toArray();
      const currentMapZoom = map.getZoom();

      // Calculate the percentage change based on the max values
      const centerChange =
        (mapboxgl.LngLat.convert(currentMapCenter).distanceTo(prevMapCenter) /
          mapboxgl.LngLat.convert([0, 0]).distanceTo([180, 0])) *
        100 >
        5; // Example distance threshold in percentage
      const zoomChange =
        (Math.abs(currentMapZoom - prevMapZoom) / maxZoom) * 100 > 2; // Example zoom threshold in percentage

      if (centerChange || zoomChange) {
        setMapCenter(currentMapCenter);
        setMapZoom(currentMapZoom);
        setMapBounds(map.getBounds());

        // Update previous values
        setPrevMapCenter(currentMapCenter);
        setPrevMapZoom(currentMapZoom);
      }
    });


    // Add markers based on search results
    for (const professional of results) {
      if (professional.geolocation) {
        let lat = professional.geolocation.latitude;
        let lng = professional.geolocation.longitude;
        MapMarker({ map, lngLat: [lat, lng], popupText: professional.name });
        /*const marker = new mapboxgl.Marker()
            .setLngLat([lng, lat])
            .setPopup()
            .addTo(map);*/

      }
    }



    return () => map.remove();
  }, [setMapBounds, results,]);

  return (
    <div
      ref={mapContainerRef}
      style={{ width: "100%", height: height * 0.8 }}
    />
  );
};

export default Map;
