// InfoGetter.js
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Dropdown from './DropMultiSelect';

const InitGetter = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios.get('API HELPPP')
      .then(response => {
        setData(response.data);
      })
      .catch(error => {
        console.error('Error fetching data:', error);
      });
  }, []); 

  return (
    <div>
      <DropMultiSelect data={data} />
    </div>
  );
};

export default InitGetter;
