import * as React from 'react';
import Box from '@mui/system/Box';
import Grid from '@mui/system/Unstable_Grid';
import DropMultiSelect from '../Components/DropMultiSelect';
import useWindowDimensions from './windowDimension';
import SearchBar from '../Components/SearchBar';
export default function Test() {
    return (
      <div style={{ width: '100%' }}>
        <Box
          sx={{
            display: 'flex',
            flexDirection: 'row',
            p: 1,
            m: 1,
            bgcolor: 'background.paper',
            borderRadius: 1,
          }}
        >
          <Box>
          <DropMultiSelect/>
          <DropMultiSelect/>
          </Box>
          <div>Item 1</div>
          <div>Item 2</div>
          <div>Item 3</div>
        </Box>
      </div>
    );
  }