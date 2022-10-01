import React, { useContext, useState } from 'react';

const CartContext = React.createContext();
const CartUpdateContext = React.createContext();

const useCart = () => useContext(CartContext);
const useCartUpdate = () => useContext(CartUpdateContext);

const CartProvider = ({ children }) => {
  const [cart, setCart] = useState(0);

  const addProduct = (product) => {
    setCart(cart + 1);
  };

  return (
    <CartContext.Provider value={cart}>
      <CartUpdateContext.Provider value={addProduct}>
        {children}
      </CartUpdateContext.Provider>
    </CartContext.Provider>
  );
};

export { CartProvider, useCart, useCartUpdate };
