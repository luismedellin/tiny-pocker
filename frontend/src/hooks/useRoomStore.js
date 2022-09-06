import { useDispatch, useSelector } from 'react-redux';
import { addRoom } from '../store';

export const useRoomStore = () => {
    const dispatch = useDispatch();

    const { counter } = useSelector(state => state.room );

    const addCounter = () => {
        dispatch(addRoom());
    }

    return {
        counter,

        addCounter
    }
}
