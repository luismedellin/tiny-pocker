import { useState } from 'react'
import { AppRouter } from './router'
import { Navbar } from './ui'

export const TinyPockerApp = () => {
  const [count, setCount] = useState(0)

  return (
    <div className="TinyPockerApp">
      <Navbar />
      <AppRouter />
    </div>
  )
}