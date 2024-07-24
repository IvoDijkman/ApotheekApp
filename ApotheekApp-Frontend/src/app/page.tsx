"use client"
import Image from "next/image";
import styles from "./page.module.css";
import * as React from "react";
import * as ReactDOM from "react-dom/client";
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import Dashboard from "./pages/dashboard/dashboard";
import ClientPage from "./pages/client/page";


const domNode = document.getElementById("dashboard");
const router = createBrowserRouter([
  //{path: "/", element: <div>home will be here?</div>},
{path: "/", element: <Dashboard />},
  //{path: "/client", element: ClientPage()}
])

if (domNode instanceof DocumentFragment)
  {
    ReactDOM.createRoot(domNode).render(
   <React.StrictMode>
      <RouterProvider router={router} />
   </React.StrictMode>   );
  }