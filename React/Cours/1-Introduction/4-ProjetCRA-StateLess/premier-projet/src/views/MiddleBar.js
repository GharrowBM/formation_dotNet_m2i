import React from "react";
import FormationList from "./FormationList"
import Formulaire from "./Formulaire"
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link
} from "react-router-dom";
import '../styles/MiddleBar.css'

function MiddleBar({cart, updateCart}) {
    return (
        <Router>
            <div>
                <nav>
                    <div>
                        <button className="btn btn-secondary bouton" >
                            <Link to="/">Accueil</Link>
                        </button>
                        <button className="btn btn-secondary bouton">
                            <Link to="/formation">Formations</Link>
                        </button>
                        <button className="btn btn-secondary bouton">
                            <Link to="/formulaires">Formulaires</Link>
                        </button>
                        <button className="btn btn-secondary bouton">
                            <Link to="/about">A propos</Link>
                        </button>
                    </div>
                </nav>

                {/* A <Switch> looks through its children <Route>s and
            renders the first one that matches the current URL. */}
                <Switch>
                    
                    <Route path="/about">
                        <About />
                    </Route>
                    <Route path="/formulaires">
                        <Formulaire />
                    </Route>
                    <Route path="/formation">
                        <FormationList cart={cart} updateCart={updateCart}/> 
                    </Route>
                    <Route path="/">
                        <Home />
                    </Route>

                </Switch>
            </div>
        </Router>
    );
}

export default MiddleBar

function Home() {
    return <h2>Home</h2>;
}

function About() {
    return <h2>About</h2>;
}

