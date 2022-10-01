import Layout from './layout/Layout';
import './custom.css';
import { Routes, Route } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { CartProvider } from './cart/CartContext';

const App = () => {
  return (
    <CartProvider>
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </Layout>
    </CartProvider>
  );
};

export default App;
