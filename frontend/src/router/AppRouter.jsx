import { Route, Routes } from 'react-router-dom';
import { Welcome } from '../home';
import { RoomPage } from '../room';

export const AppRouter = () => {
  return (
    <Routes>
        <Route path="room" element={ <RoomPage /> } />
        <Route path="*" element={ <Welcome /> } />
    </Routes>
  )
}
