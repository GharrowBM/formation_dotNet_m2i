import { PureComponent } from "react"
import { connect } from "react-redux"
import { getWeather } from "../redux/actions";
import { Row, Col, Input, Button } from "antd"
class FormContainer extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            city : null
        }
    }

    getWeatherClick = () => {
        this.props.getWeather(this.state.city)
    }
    render() {
        return (
            <div>
                <Row justify="center">
                    <Col span={5}>
                        <Input onChange={e=> this.setState({city:e.target.value})} placeholder="Ville..." />
                    </Col>
                    <Col span={5}>
                        <Input placeholder="Pays..." />
                    </Col>
                    <Col span={2}>
                        <Button type="primary" onClick={this.getWeatherClick}  loading={this.props.loading}>
                            Get Weather
                        </Button>
                    </Col>
                </Row>
            </div>
        );
    }
}


const mapStateToProps = (state) => {
    return {
        loading: state.weather.isLoading
    }
}

const mapActionToProps = (dispatch) => {
    return {
        getWeather: (city) => dispatch(getWeather(city))
    }
}

export default connect(mapStateToProps, mapActionToProps)(FormContainer);