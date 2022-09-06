import { Provider } from 'react-redux'
import { AppRouter } from './router'
import { store } from './store'
import { Navbar } from './ui'

export const TinyPockerApp = () => {

  return (
    <Provider store={ store }>
      <Navbar />
      <AppRouter />
    </Provider>
  )
}