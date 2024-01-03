// Map.js
import React, { useEffect, useRef, useState } from "react";
import mapboxgl from "mapbox-gl";
import "mapbox-gl/dist/mapbox-gl.css";
import MapMarker from "./MapMarker";
import useWindowDimensions from "../utils/windowDimension";

mapboxgl.accessToken =
  "pk.eyJ1Ijoic29uZHJlbHV4IiwiYSI6ImNsbnZ3aXRneDAzcDcydG82NGE2dG4xYnQifQ._TpEa0XTz2SpM5Zv9xju_w";

export default function Map({ setMapBounds }) {
  const mapContainerRef = useRef(null);
  const { height, width } = useWindowDimensions();

  useEffect(() => {
    const map = new mapboxgl.Map({
      container: mapContainerRef.current,
      style: "mapbox://styles/mapbox/streets-v11",
      center: [1.4442, 43.6047],
      zoom: 12,
    });

    const nav = new mapboxgl.NavigationControl({
      showZoom: true,
      showCompass: false
    });

    map.addControl(nav, 'bottom-right');

    // Add markers after the map is initialized
    MapMarker({ map, lngLat: [1.4442, 43.6047], popupText: "DOCTOR 1" });
    MapMarker({ map, lngLat: [1.455, 43.609], popupText: "DOCTOR 2" });

    // Set initial map bounds
    setMapBounds(map.getBounds());
    console.log(map.getBounds());

    // Listen for map move events and update bounds
    map.on("move", () => {
      setMapBounds(map.getBounds());
    });

    return () => map.remove();
  }, [setMapBounds]);

  return (
    <div
      ref={mapContainerRef}
      style={{ width: "100%", height: height * 0.8 }}
    />
  );
}
