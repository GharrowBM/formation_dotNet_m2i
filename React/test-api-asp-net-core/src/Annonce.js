import {PureComponent} from "react"
import axios from "axios"
export class Annonce extends PureComponent {
    
    constructor(props) {
        super(props)
        this.state = {
            annonces : []
        }
    }

    componentDidMount() {
        axios.get('http://localhost:5000/api/v1/annonces').then(res => {
            this.setState({
                annonces : res.data
            })
        })
    }

    render() {
        return(
            <div>

            </div>
        )
    }
}