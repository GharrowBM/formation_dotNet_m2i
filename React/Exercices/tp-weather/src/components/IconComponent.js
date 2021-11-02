import { Row, Col } from "antd"
export const IconComponent = (props) => {
    return (
        <>
            <Row justify="center">
                <Col>
                    <img src={props.icon} />
                </Col>
            </Row>
            <Row justify="center">
                <Col>
                    {props.description}
                </Col>
            </Row>
        </>

    )
}